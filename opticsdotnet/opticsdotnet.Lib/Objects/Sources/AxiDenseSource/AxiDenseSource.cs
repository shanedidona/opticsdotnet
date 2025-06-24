namespace opticsdotnet.Lib
{
    public sealed class AxiDenseSource : IAxiRaySource
    {
        readonly double[] Z0s;
        readonly double[] R0s;
        readonly double[] Thetas;
        readonly double[] WaveLengths;
        readonly double? Intensity;
        readonly IAxiDenseSourceMathematicaDirectiveGenerator AxiDenseSourceMathematicaDirectiveGenerator;

        public AxiDenseSource(
                double[] z0s,
                double[] r0s,
                double[] thetas,
                double[] waveLengths,
                double? intensity,
                IAxiDenseSourceMathematicaDirectiveGenerator axiDenseSourceMathematicaDirectiveGenerator = null
            )
        {
            Z0s = z0s;
            R0s = r0s;
            Thetas = thetas;
            WaveLengths = waveLengths;
            Intensity = intensity;
            AxiDenseSourceMathematicaDirectiveGenerator = axiDenseSourceMathematicaDirectiveGenerator;
        }

        public IEnumerable<AxiRay> AxiRays()
        {
            int z0Index = 0;
            foreach (double z0 in Z0s)
            {
                int r0Index = 0;
                foreach (double r0 in R0s)
                {
                    int thetaIndex = 0;
                    foreach (double theta in Thetas)
                    {
                        int waveLengthIndex = 0;
                        foreach (double waveLength in WaveLengths)
                        {
                            yield return new AxiRay(
                                    new AxiRayState(z0, r0, theta, waveLength, Intensity),
                                    AxiDenseSourceMathematicaDirectiveGenerator?.GenerateAxiDenseSourceMathematicaDirectiveArray(
                                                z0Index, r0Index, thetaIndex, waveLengthIndex,
                                                z0, r0, theta, waveLength
                                            )
                                );

                            waveLengthIndex++;
                        }

                        thetaIndex++;
                    }

                    r0Index++;
                }

                z0Index++;
            }
        }

        public string RenderMathematica()
        {
            return new Point2D(0, 0).RenderMathematica();
        }
    }
}
