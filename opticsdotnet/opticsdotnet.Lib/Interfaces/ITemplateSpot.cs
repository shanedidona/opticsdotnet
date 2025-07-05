namespace opticsdotnet.Lib
{
    public interface ITemplateSpot
    {
        public Type ItemType { get; }
    }

    public interface ITemplateSpot<T> : ITemplateSpot
    {
    }
}
