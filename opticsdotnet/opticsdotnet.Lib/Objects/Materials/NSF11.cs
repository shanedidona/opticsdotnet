namespace opticsdotnet.Lib
{
    public sealed class NSF11 : IOpticalMaterial
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=6973&tabname=N-SF11
        //https://www.thorlabs.com/images/TabImages/Uncoated_N-SF11_Transmission.xlsx

        const double B1 = 1.73759695;
        const double B2 = 0.313747346;
        const double B3 = 1.89878101;
        const double C1 = 0.013188707;
        const double C2 = 0.0623068142;
        const double C3 = 155.23629;

        static readonly LinearSplineWithMinMax AbsorptionCoefficientLinearSplineWithMinMax = IOUtil.LinearSplineWithMinMaxFromCSVFile("Data//NSF11//NFS11_AttenuationCoeffs.csv");

        public double? IndexOfRefractionMinWavelength => 370;

        public double? IndexOfRefractionMaxWavelength => 2500;

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
