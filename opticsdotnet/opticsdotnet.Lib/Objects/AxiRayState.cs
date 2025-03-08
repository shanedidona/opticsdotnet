namespace opticsdotnet.Lib
{
    public sealed class AxiRayState
    {
        public readonly double Z0;
        public readonly double R0;
        public readonly double Theta;
        public readonly double WaveLength;
        public readonly double Intensity;

        public AxiRayState(double z0, double r0, double theta, double waveLength, double intensity)
        {
            Z0 = z0;
            R0 = r0;
            Theta = theta;
            WaveLength = waveLength;
            Intensity = intensity;
        }
    }
}
