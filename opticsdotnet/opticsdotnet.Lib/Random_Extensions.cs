namespace opticsdotnet.Lib
{
    public static class Random_Extensions
    {
        public static double NextInRange(this Random random, double minInc, double maxExc)
        {
            return (maxExc - minInc) * random.NextDouble() + minInc;
        }
    }
}
