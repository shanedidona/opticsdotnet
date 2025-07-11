﻿using opticsdotnet.Lib;

namespace opticsdotnet.Testing.ODN36
{
    public static class ODN36
    {
        public static void ODN36_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-36");
            Directory.CreateDirectory(saveDir);

            var axiDenseSource = new AxiDenseSource(
                                            new double[] { -0.001, 0 },
                                            new double[] { -0.001, 0, 0.001 },
                                            new double[] { -0.4, -0.05, 0, 0.05, 0.4 },
                                            new double[] { 440, 540, 640 },
                                            1.0,
                                            new ColorFromWaveLength()
                                        );

            var axiDrifts = new AxiDrift[]
            {
                new AxiDrift(new Vacuum(), 0.02),
                new AxiDrift(new Vacuum(), 0.03),
                new AxiDrift(new Vacuum(), 0.05),
                new AxiDrift(new Vacuum(), 0.04)
            };

            var axiElements = new IAxiOpticalElement[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1859(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1255(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1859().ReturnFlipped()
            };

            var axiRayTerminator = new AxiFlatTerminator();

            AxiOpticalAssembly axiOpticalAssembly = new AxiOpticalAssembly(axiDrifts, axiElements);


            AxiOpticalSystem axiOpticalSystem = new AxiOpticalSystem(
                    axiDenseSource, axiOpticalAssembly, axiRayTerminator
                );

            axiOpticalSystem.RayTrace();

            string string1 = axiOpticalSystem.RenderMathematica();

            File.WriteAllText(Path.Combine(saveDir, "ODN36_1.txt"), string1);

            AxiRayState[] initialStates = new AxiRayState[]
            {
                new AxiRayState(0, 0, 0, 500, 1),
                new AxiRayState(0, 0, 0.01, 500, 1)
            };

            AxiRay[] individualRaysOut = initialStates.Select(initialState => axiOpticalAssembly.RayTraceSingleRay(new AxiRay(initialState))).ToArray();


        }

        public static void ODN36_2()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-36");
            Directory.CreateDirectory(saveDir);

            var axiDenseSource = new AxiDenseSource(
                                            new double[] { 0 },
                                            new double[] { -0.001, 0, 0.001 },
                                            new double[] { 0 },
                                            new double[] { 587.6 },
                                            1.0
                                        );

            var axiDrifts = new AxiDrift[]
            {
                new AxiDrift(new Vacuum(), 0.02),
                new AxiDrift(new Vacuum(), 0.03),
            };

            var axiElements = new IAxiOpticalElement[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1859()
            };

            var axiRayTerminator = new AxiFlatTerminator();

            AxiOpticalSystem axiOpticalSystem = new AxiOpticalSystem(
                    axiDenseSource, axiDrifts, axiElements, axiRayTerminator
                );

            axiOpticalSystem.RayTrace();

            Line2D[] linesOut = axiOpticalSystem.LinesOut();
            Point2D focalPoint = Geo2D.ClosestPointToLines(linesOut);

            string string1 = axiOpticalSystem.RenderMathematica();

            File.WriteAllText(Path.Combine(saveDir, "ODN36_2.txt"), string1);
        }

        public static void ODN36_3()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-36");
            Directory.CreateDirectory(saveDir);

            double beamRadius = 0.001;
            int numRays = 5;
            double frontDriftLength = 0.01;
            double backDriftLength = 0.01;

            var testDatas = new List<(SphericalSinglet SphericalSinglet1, double EexpectedFocalZRelToBack, double TestWaveLengthNM)>();

            testDatas.Add((opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1859(), 0.0153, 587.6));

            testDatas.Add((opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LBF254_040(), 0.0363, 587.6));
            testDatas.Add((opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LBF254_200(), 0.1978, 587.6));
            
            testDatas.Add((opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LC1975(), -0.0252, 587.6));

            testDatas.Add((opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LE1929(), 0.2965, 587.6));

            testDatas.Add((opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LF1141(), -0.9946, 587.6));

            testDatas.Add((opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LD2060(), -0.0157, 587.6));
            testDatas.Add((opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LD1357(), -0.0510, 587.6));

            var focalPointRelToBacks = new List<Point2D>();
            foreach (var testData in testDatas)
            {
                focalPointRelToBacks.Add(
                                        Analysis.CalculateFocalPointRelToBack(
                                        beamRadius,
                                        numRays,
                                        testData.TestWaveLengthNM,
                                        frontDriftLength,
                                        backDriftLength,
                                        testData.SphericalSinglet1
                                    )
                                );
            }

            double[] fracZErrors = Enumerable.Range(0, testDatas.Count)
                .Select(
                            i => (focalPointRelToBacks[i].X - testDatas[i].EexpectedFocalZRelToBack) / testDatas[i].EexpectedFocalZRelToBack
                        )
                .ToArray();

            double maxAbsFracZError = fracZErrors.Select(Math.Abs).Max();
            double maxAbsFocalY = focalPointRelToBacks.Select(x => Math.Abs(x.Y)).Max();
        }
    }
}
