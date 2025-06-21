namespace opticsdotnet.Lib
{
    public abstract class PossibleValueSet<T>
    {
        public abstract int? NumItems { get; }//Null means infinity
        public abstract T FirstItem { get; }
        public abstract T LastItem { get; }
    }
}
