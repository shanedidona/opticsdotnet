namespace opticsdotnet.Lib
{
    public sealed class SingleValuePossibleValueSet<T> : PossibleValueSet<T>
    {
        public readonly T Item;

        public SingleValuePossibleValueSet(T item)
        {
            Item = item;
        }

        public override int? NumItems => 1;

        public override T FirstItem => Item;

        public override T LastItem => Item;
    }
}
