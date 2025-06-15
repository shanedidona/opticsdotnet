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

        static readonly LinearSplineWithMinMax AbsorptionCoefficientLinearSplineWithMinMax = IOUtil.LinearSplinesWithMinMaxFromCSVFile("Data//NSF11//NSF11_AttenuationCoeffs.csv")[0];

        public double? IndexOfRefractionMinWavelength => 370;

        public double? IndexOfRefractionMaxWavelength => 2500;

        public double? AbsorptionCoefficientMinWavelength => AbsorptionCoefficientLinearSplineWithMinMax.MinIndep;

        public double? AbsorptionCoefficientMaxWavelength => AbsorptionCoefficientLinearSplineWithMinMax.MaxIndep;

        public double? AbsorptionCoefficient(double wavelength)
        {
            if (wavelength < AbsorptionCoefficientMinWavelength)
            {
                return null;
            }

            if (AbsorptionCoefficientMaxWavelength < wavelength)
            {
                return null;
            }

            return AbsorptionCoefficientLinearSplineWithMinMax.LinearSpline1.Interpolate(wavelength);
        }

        public double? IndexOfRefraction(double wavelength)
        {
            if (wavelength < IndexOfRefractionMinWavelength)
            {
                return null;
            }

            if (IndexOfRefractionMaxWavelength < wavelength)
            {
                return null;
            }

            return PhysicsUtil.SellmeierEvaluate(wavelength, B1, B2, B3, C1, C2, C3);
        }
    }
}
