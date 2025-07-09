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
        public NumItemMetricGroup(NumItemMetricGroup[] groupsToMultiply)
        {
            bool continuousFound = false;
            BigInteger excludingContinuous = 1;

            foreach (NumItemMetricGroup numItemMetricGroup in groupsToMultiply)
            {
                if (numItemMetricGroup.NumItemsIncludingContinuous.HasValue)
                {
                    excludingContinuous *= NumItemsIncludingContinuous.Value;
                }
                else
                {
                    continuousFound = true;
                }
            }

            BigInteger? includingContinuous = continuousFound ? null : excludingContinuous;

            NumItemsExcludingContinuous = excludingContinuous;
            NumItemsIncludingContinuous = includingContinuous;
        }
    }
}
