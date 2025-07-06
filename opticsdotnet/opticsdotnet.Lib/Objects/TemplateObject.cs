using System.Reflection;

namespace opticsdotnet.Lib
{
    public sealed class TemplateObject<T> : ITemplateSpot<T>
    {
        readonly ConstructorInfo ConstructorInfo1;
        public readonly PossibleValueSet[] PossibleValueSets;

        public TemplateObject(PossibleValueSet[] possibleValueSets)
        {
            PossibleValueSets = possibleValueSets;

            ConstructorInfo1 = typeof(T).GetConstructor(possibleValueSets.Select(x => x.ItemType).ToArray());

            if (ConstructorInfo1 == null)
            {
                throw new NotSupportedException("ConstructorInfo1 == null");
            }
        }

        public Type ItemType => typeof(T);
    }
}
