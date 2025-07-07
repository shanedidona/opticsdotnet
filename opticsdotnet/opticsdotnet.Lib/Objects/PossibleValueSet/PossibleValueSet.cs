using System.Numerics;

namespace opticsdotnet.Lib
{
    public abstract class PossibleValueSet : ITemplateSpot
    {
        public abstract NumItemMetricGroup NumItemMetricGroup1 { get; }
        public abstract Type ItemType { get; }
    }

    public abstract class PossibleValueSet<T> : PossibleValueSet, ITemplateSpot<T>
    {
        public abstract T FirstItem { get; }
        public abstract T LastItem { get; }
    }

    public static class PossibleValueSet_Extensions
    {
        public static (BigInteger? IncludingContinuous, BigInteger ExcludingContinuous) NumberOfPermutations(this PossibleValueSet[] possibleValueSets)
        {
            bool continuousFound = false;
            BigInteger excludingContinuous = 1;

            foreach (PossibleValueSet possibleValueSet in possibleValueSets)
            {
                if (possibleValueSet.NumItems.HasValue)
                {
                    excludingContinuous *= possibleValueSet.NumItems.Value;
                }
                else
                {
                    continuousFound = true;
                }
            }

            BigInteger? includingContinuous = continuousFound ? null : excludingContinuous;

            return (includingContinuous, excludingContinuous);
        }
    }
}
