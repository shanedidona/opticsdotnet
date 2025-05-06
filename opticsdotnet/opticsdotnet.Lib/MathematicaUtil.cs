using System.Text;

namespace opticsdotnet.Lib
{
    public static class MathematicaUtil
    {
        public const string Nothing = "Nothing";

        public static void woooo<TKey, TValue>(Dictionary<TKey, TValue> dict) where TKey : IMathematicaRenderable, TValue where TValue : IMathematicaRenderable
        {
            StringBuilder sb1 = new StringBuilder();

            KeyValuePair<TKey,TValue>[] keyValuePairs = dict.ToArray();

            sb1.Append("<|");

            foreach (KeyValuePair<TKey, TValue> keyValuePair in keyValuePairs)
            {

            }

            sb1.Append("|>");



        }









    }
}
