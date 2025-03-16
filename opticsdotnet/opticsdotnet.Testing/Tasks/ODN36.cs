using opticsdotnet.Lib;

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
                                            new double[] { -0.05, 0, 0.05 },
                                            new double[] { 500, 600, 700 },
                                            1.0
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


            AxiOpticalSystem axiOpticalSystem = new AxiOpticalSystem(
                    axiDenseSource, axiDrifts, axiElements, axiRayTerminator
                );

            axiOpticalSystem.RayTrace();

            string string1 = axiOpticalSystem.RenderMathematica();

            File.WriteAllText(Path.Combine(saveDir, "ODN36_1.txt"), string1);
        }
    }
}
