using System.Numerics;

namespace opticsdotnet.Lib
{
    public sealed class NumItemMetricGroup
    {
        public readonly BigInteger? NumItemsIncludingContinuous;//Null means infinity

        public NumItemMetricGroup(BigInteger? numItemsIncludingContinuous)
        {
            NumItemsIncludingContinuous = numItemsIncludingContinuous;
        }
    }
}
