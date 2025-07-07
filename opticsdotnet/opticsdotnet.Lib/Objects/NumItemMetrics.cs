using System.Numerics;

namespace opticsdotnet.Lib
{
    public sealed class NumItemMetricGroup
    {
        public readonly BigInteger? NumItemsIncludingContinuous;

        public NumItemMetricGroup(BigInteger? numItemsIncludingContinuous)
        {
            NumItemsIncludingContinuous = numItemsIncludingContinuous;
        }
    }
}
