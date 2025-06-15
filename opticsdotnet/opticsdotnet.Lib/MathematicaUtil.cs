using opticsdotnet.Lib.Mathematica;
using System.Text;

namespace opticsdotnet.Lib
{
    public static class MathematicaUtil
    {
        public const string Nothing = "Nothing";

        public static string DictionaryToMathematicaAssociation<TValue>(Dictionary<string, TValue> dict) where TValue : IMathematicaRenderable
        {
            StringBuilder sb1 = new StringBuilder();

            sb1.Append("<|");

            sb1.Append(
                string.Join(
                        ", ",
                        dict.Select(keyValuePair => (new StringMathematicaAdapter(keyValuePair.Key)).RenderMathematica() + " -> " + keyValuePair.Value.RenderMathematica())
                        )
            );

            sb1.Append("|>");

            return sb1.ToString();
        }
    }
}
