namespace opticsdotnet.Lib
{
    public abstract class TemplateSpot
    {
        public Type ItemType { get; }
    }

    public abstract class TemplateSpot<T> : TemplateSpot
    {

    }
}
