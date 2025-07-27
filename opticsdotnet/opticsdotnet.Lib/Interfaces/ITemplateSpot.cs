namespace opticsdotnet.Lib
{
    public interface ITemplateSpot
    {
        public NumItemMetricGroup NumItemMetricGroup1 { get; }
        public Type ItemType { get; }
    }

    public interface ITemplateSpot<T> : ITemplateSpot
    {
    }
}
