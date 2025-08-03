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

        public static IEnumerable<T> Flatten2D<T>(this IEnumerable<IEnumerable<T>> jagged)
        {
            foreach (IEnumerable<T> iEnumerable in jagged)
            {
                foreach (T value in jagged)
                {
                    yield return value;
                }
            }
        }
    }
}
