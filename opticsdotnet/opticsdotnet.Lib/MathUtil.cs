namespace opticsdotnet.Lib
{
    public static class MathUtil
    {
        public const double PiOver2 = 0.5 * Math.PI;

        public const double SmallAngle = 1E-9;

        public static double Sq(double value)
        {
            return value * value;
        }
    }
}
