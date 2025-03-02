namespace opticsdotnet.Lib
{
    public interface IOpticalMaterial
    {
        double? IndexOfRefractionMinWavelength { get; }
        double? IndexOfRefractionMaxWavelength { get; }
        double? IndexOfRefraction(double wavelength);//In Nanometers

        double? AbsorptionCoefficientMinWavelength { get; }
        double? AbsorptionCoefficientMaxWavelength { get; }
        double? AbsorptionCoefficient(double wavelength);//Returns 1/m (where 1 atten for 1 meter results in e^-1 transmission), accepts nanometers
    }
}
