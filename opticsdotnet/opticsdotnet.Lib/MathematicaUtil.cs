using System.Text;

namespace opticsdotnet.Lib
{
    public static class MathematicaUtil
    {
        public const string Nothing = "Nothing";

        public static void woooo<TValue>(Dictionary<string, TValue> dict) where TValue : IMathematicaRenderable
        {
            StringBuilder sb1 = new StringBuilder();

            KeyValuePair<string,TValue>[] keyValuePairs = dict.ToArray();

            sb1.Append("<|");

            foreach (KeyValuePair<string, TValue> keyValuePair in keyValuePairs)
            {

            }

            sb1.Append("|>");



        }









    }
}
