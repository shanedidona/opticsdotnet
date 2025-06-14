namespace opticsdotnet.Lib
{
    public sealed class NBK7 : IOpticalMaterial
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=6973&tabname=N-BK7
        //https://www.thorlabs.com/images/TabImages/Uncoated_N-BK7_Transmission_4microns.xlsx

        const double B1 = 1.03961212;
        const double B2 = 0.231792344;
        const double B3 = 1.01046945;
        const double C1 = 0.00600069867;
        const double C2 = 0.0200179144;
        const double C3 = 103.560653;

        static readonly LinearSplineWithMinMax AbsorptionCoefficientLinearSplineWithMinMax = IOUtil.LinearSplinesWithMinMaxFromCSVFile("Data//NBK7//NBK7_AttenuationCoeffs.csv")[0];

        public double? IndexOfRefractionMinWavelength => 300;

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
