namespace opticsdotnet.Lib
{
    public sealed class NSF11 : IOpticalMaterial
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=6973&tabname=N-SF11
        //https://www.thorlabs.com/images/TabImages/Uncoated_N-SF11_Transmission.xlsx


        static readonly LinearSplineWithMinMax AbsorptionCoefficientLinearSplineWithMinMax = IOUtil.LinearSplineWithMinMaxFromCSVFile("Data//NSF11//NFS11_AttenuationCoeffs.csv");

        public double? IndexOfRefractionMinWavelength => throw new NotImplementedException();

        public double? IndexOfRefractionMaxWavelength => throw new NotImplementedException();

        public double? AbsorptionCoefficientMinWavelength => AbsorptionCoefficientLinearSplineWithMinMax.MinIndep;

        public double? AbsorptionCoefficientMaxWavelength => AbsorptionCoefficientLinearSplineWithMinMax.MaxIndep;

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
