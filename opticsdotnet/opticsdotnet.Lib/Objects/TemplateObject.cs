namespace opticsdotnet.Lib
{
    public sealed class TemplateObject<T> : ITemplateSpot<T>
    {
        public readonly PossibleValueSet[] PossibleValueSets;

        public TemplateObject(PossibleValueSet[] possibleValueSets)
        {
            PossibleValueSets = possibleValueSets;
        }

        public Type ItemType => typeof(T);
    }
}
