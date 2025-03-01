namespace opticsdotnet.Lib
{
    public interface IOpticalMaterial
    {
        double? IndexOfRefraction(double wavelength);//In Nanometers
        double? AbsorptionCoefficient(double wavelength);//Returns 1/m (where 1 atten for 1 meter results in e^-1 transmission), accepts nanometers
    }
}
