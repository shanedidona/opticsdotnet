using System.Numerics;

namespace opticsdotnet.Lib
{
    public class ArrayPossibleValueSet<T> : PossibleValueSet<T>
    {
        public readonly T[] Items;

        public ArrayPossibleValueSet(T[] items)
        {
            Items = items;

            foreach (T item in items)
            {
                if (typeof(T).IsAssignableTo(typeof(ITemplateSpot)))
                {
                    throw new NotSupportedException("typeof(T).IsAssignableTo(typeof(ITemplateSpot))");
                }
            }
        }

        public override NumItemMetricGroup NumItemMetricGroup1 => new NumItemMetricGroup(Items.Length);

        public override T FirstItem => Items.First();

        public override T LastItem => Items.Last();

        public override Type ItemType => typeof(T);
    }
}
