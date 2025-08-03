namespace opticsdotnet.Lib
{
    public abstract class PossibleValueSet : ITemplateSpot
    {
        public abstract NumItemMetricGroup NumItemMetricGroup1 { get; }
        public abstract Type ItemType { get; }

        public PossibleValueSet[] PossibleValueSets => new PossibleValueSet[] { this };
    }

    public abstract class PossibleValueSet<T> : PossibleValueSet, ITemplateSpot<T>
    {
        public abstract T FirstItem { get; }
        public abstract T LastItem { get; }
    }
}
