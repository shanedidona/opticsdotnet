using System.Numerics;

namespace opticsdotnet.Lib
{
    public sealed class NumItemMetricGroup
    {
        public readonly BigInteger? NumItemsIncludingContinuous;//Null means infinity
        public readonly BigInteger NumItemsExcludingContinuous;

        public NumItemMetricGroup(
                BigInteger? numItemsIncludingContinuous,
                BigInteger numItemsExcludingContinuous
            )
        {
            NumItemsIncludingContinuous = numItemsIncludingContinuous;
            NumItemsExcludingContinuous = numItemsExcludingContinuous;
        }
    }
}
