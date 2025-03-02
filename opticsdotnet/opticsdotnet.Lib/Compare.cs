namespace opticsdotnet.Lib
{
    public static class Compare
    {
        public static bool ValidateIncreasing<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length < 2) { return true; }

            for (int i = 1; i < array.Length; i++)
            {
                if (0 <= array[i - 1].CompareTo(array[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
