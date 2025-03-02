namespace opticsdotnet.Lib
{
    public sealed class Vacuum : IOpticalMaterial
    {
        public double? IndexOfRefractionMinWavelength => null;

        public double? IndexOfRefractionMaxWavelength => null;

        public double? AbsorptionCoefficientMinWavelength => null;

        public double? AbsorptionCoefficientMaxWavelength => null;

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
