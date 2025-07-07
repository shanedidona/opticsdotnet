using System.Numerics;

namespace opticsdotnet.Lib
{
    public sealed class RangePossibleValueSet : PossibleValueSet<double>
    {
        public readonly double Min1;
        public readonly double Max1;

        public RangePossibleValueSet(double min, double max)
        {
            Min1 = min;
            Max1 = max;
        }

        public override NumItemMetricGroup NumItemMetricGroup1 => new NumItemMetricGroup(null);

        public override double FirstItem => Min1;

        public override double LastItem => Max1;

        public override Type ItemType => typeof(double);
    }
}
