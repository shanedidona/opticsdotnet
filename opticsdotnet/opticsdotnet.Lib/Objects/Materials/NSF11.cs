namespace opticsdotnet.Lib
{
    public sealed class NSF11 : IOpticalMaterial
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=6973&tabname=N-SF11
        //https://www.thorlabs.com/images/TabImages/Uncoated_N-SF11_Transmission.xlsx


        public double? IndexOfRefractionMinWavelength => throw new NotImplementedException();

        public double? IndexOfRefractionMaxWavelength => throw new NotImplementedException();

        public double? AbsorptionCoefficientMinWavelength => throw new NotImplementedException();

        public double? AbsorptionCoefficientMaxWavelength => throw new NotImplementedException();

        public double? AbsorptionCoefficient(double wavelength)
        {
            throw new NotImplementedException();
        }

        public double? IndexOfRefraction(double wavelength)
        {
            throw new NotImplementedException();
        }
    }
}
