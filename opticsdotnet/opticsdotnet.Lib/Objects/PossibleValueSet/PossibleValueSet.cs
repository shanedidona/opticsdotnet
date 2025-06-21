using System.Numerics;

namespace opticsdotnet.Lib
{
    public abstract class PossibleValueSet
    {
        public abstract int? NumItems { get; }//Null means infinity
    }

    public abstract class PossibleValueSet<T> : PossibleValueSet
    {
        public abstract T FirstItem { get; }
        public abstract T LastItem { get; }
    }

    public static class PossibleValueSet_Extensions
    {
        public static BigInteger? NumberOfPermutations(this PossibleValueSet[] possibleValueSets)
        {
            BigInteger out1 = 1;

            foreach (PossibleValueSet possibleValueSet in possibleValueSets)
            {
                if (possibleValueSet.NumItems.HasValue)
                {
                    out1 *= possibleValueSet.NumItems.Value;
                }
                else
                {
                    return null;
                }
            }

            return out1;
        }
    }
}
