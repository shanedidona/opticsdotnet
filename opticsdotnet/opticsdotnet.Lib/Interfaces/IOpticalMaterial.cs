namespace opticsdotnet.Lib
{
    public interface IOpticalMaterial
    {
        double? IndexOfRefraction(double wavelength);//In Nanometers
        double? AbsorptionCoefficient(double wavelength);//Returns 1/m, accepts nanometers
    }
}
