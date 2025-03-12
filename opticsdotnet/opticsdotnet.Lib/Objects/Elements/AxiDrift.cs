namespace opticsdotnet.Lib
{
    public sealed class AxiDrift
    {
        public readonly double Length1;
        public readonly IOpticalMaterial OpticalMaterial;

        public AxiDrift(IOpticalMaterial opticalMaterial, double length)
        {
            OpticalMaterial = opticalMaterial;
            Length1 = length;
        }
    }
}
