namespace opticsdotnet.Lib
{
    public sealed class NBK7 : IOpticalMaterial
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=6973&tabname=N-BK7
        const double B1 = 1.03961212;
        const double B2 = 0.231792344;
        const double B3 = 1.01046945;
        const double C1 = 0.00600069867;
        const double C2 = 0.0200179144;
        const double C3 = 103.560653;


        public double? AbsorptionCoefficient(double wavelength)
        {
            
        }

        public double? IndexOfRefraction(double wavelength)
        {
            if (wavelength < 300)
            {
                return null;
            }

            if (2500 < wavelength)
            {
                return null;
            }

            return PhysicsUtil.SellmeierEvaluate(wavelength, B1, B2, B3, C1, C2, C3);
        }
    }
}
