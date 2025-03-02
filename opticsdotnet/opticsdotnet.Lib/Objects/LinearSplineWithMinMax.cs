using MathNet.Numerics.Interpolation;

namespace opticsdotnet.Lib
{
    public sealed class LinearSplineWithMinMax
    {
        public readonly LinearSpline LinearSpline1;
        public readonly double MinIndep;
        public readonly double MaxIndep;

        public LinearSplineWithMinMax(LinearSpline linearSpline, double minIndep, double maxIndep)
        {
            LinearSpline1 = linearSpline;
            MinIndep = minIndep;
            MaxIndep = maxIndep;
        }
    }
}
