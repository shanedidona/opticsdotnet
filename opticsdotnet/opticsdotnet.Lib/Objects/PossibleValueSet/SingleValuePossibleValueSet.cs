namespace opticsdotnet.Lib
{
    public sealed class SingleValuePossibleValueSet<T> : ArrayPossibleValueSet<T>
    {
        public SingleValuePossibleValueSet(T item) : base([item])
        {

        }
    }
}
