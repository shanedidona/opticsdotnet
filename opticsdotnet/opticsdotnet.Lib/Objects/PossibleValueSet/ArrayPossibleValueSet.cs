namespace opticsdotnet.Lib
{
    public class ArrayPossibleValueSet<T> : PossibleValueSet<T>
    {
        public readonly T[] Items;

        public ArrayPossibleValueSet(T[] items)
        {
            Items = items;
        }

        public override int? NumItems => Items.Length;

        public override T FirstItem => Items.First();

        public override T LastItem => Items.Last();

        public override Type ItemType => typeof(T);
    }
}
