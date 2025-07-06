using System.Numerics;

namespace opticsdotnet.Lib
{
    public abstract class PossibleValueSet : TemplateSpot
    {
        public abstract int? NumItems { get; }//Null means infinity
        public abstract Type ItemType { get; }
    }

    public abstract class PossibleValueSet<T> : PossibleValueSet, TemplateSpot<T>
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
