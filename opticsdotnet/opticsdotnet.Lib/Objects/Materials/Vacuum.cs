namespace opticsdotnet.Lib
{
    public sealed class Vacuum : IOpticalMaterial
    {
        public double? AbsorptionCoefficient(double wavelength)
        {
            return 0;
        }

        public double? IndexOfRefraction(double wavelength)
        {
            return 1;
        }
    }
}
