using System.Text;

namespace opticsdotnet.Lib.Mathematica
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

        public static string RenderMathematicaWithDirectives(this IMathematicaRenderable mathematicaRenderable, params MathematicaDirective[] mathematicaDirectives)
        {
            if (mathematicaDirectives != null || mathematicaDirectives.Length == 0)
            {
                return mathematicaRenderable.RenderMathematica();
            }

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("{Directive[");
            sb1.Append(
                    string.Join(",", mathematicaDirectives.Select(x => x.RenderMathematica()).ToArray())
                );
            sb1.Append("],");
            sb1.Append(mathematicaRenderable.RenderMathematica());
            sb1.Append("}");

            return sb1.ToString();
        }
    }
}
