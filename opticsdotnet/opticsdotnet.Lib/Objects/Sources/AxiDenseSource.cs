namespace opticsdotnet.Lib
{
    public sealed class AxiDenseSource : IAxiRaySource
    {
        readonly IEnumerable<double> Z0s;
        readonly IEnumerable<double> R0s;
        readonly IEnumerable<double> Thetas;
        readonly IEnumerable<double> WaveLengths;
        readonly double? Intensity;

        public AxiDenseSource(
                IEnumerable<double> z0s,
                IEnumerable<double> r0s,
                IEnumerable<double> thetas,
                IEnumerable<double> waveLengths,
                double? intensity
            )
        {
            Z0s = z0s;
            R0s = r0s;
            Thetas = thetas;
            WaveLengths = waveLengths;
            Intensity = intensity;
        }

        public IEnumerable<AxiRay> AxiRays()
        {
            foreach (double z0 in Z0s)
            {
                foreach (double r0 in R0s)
                {
                    foreach (double theta in Thetas)
                    {
                        foreach (double waveLength in WaveLengths)
                        {
                            yield return new AxiRay(
                                    new AxiRayState(z0, r0, theta, waveLength, Intensity)
                                );
                        }
                    }
                }
            }
        }

        public string RenderMathematica()
        {
            return new Point2D(0, 0).RenderMathematica();
        }
    }
}
