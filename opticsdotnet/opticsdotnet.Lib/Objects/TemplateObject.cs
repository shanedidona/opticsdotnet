namespace opticsdotnet.Lib
{
    public sealed class TemplateObject<T> : ITemplateSpot
    {
        public readonly PossibleValueSet[] PossibleValueSets;

        public TemplateObject(PossibleValueSet[] possibleValueSets)
        {
            PossibleValueSets = possibleValueSets;
        }
    }
}
