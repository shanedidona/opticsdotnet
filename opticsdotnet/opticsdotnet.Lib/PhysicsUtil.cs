namespace opticsdotnet.Lib
{
    public static class PhysicsUtil
    {
        public static double SellmeierEvaluate(
                double wavelength,//nanometers
                double b1,
                double b2,
                double b3,
                double c1,
                double c2,
                double c3
            )
        {
            double lambdaSquared = 0.001 * wavelength;
            lambdaSquared = lambdaSquared * lambdaSquared;

            double nSquared = 1;
            nSquared += b1 * lambdaSquared / (lambdaSquared - c1);
            nSquared += b2 * lambdaSquared / (lambdaSquared - c2);
            nSquared += b3 * lambdaSquared / (lambdaSquared - c3);

            return Math.Sqrt(nSquared);
        }
    }
}
