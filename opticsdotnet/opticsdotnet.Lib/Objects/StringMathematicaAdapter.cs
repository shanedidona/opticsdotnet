using System.Text;

namespace opticsdotnet.Lib
{
    public sealed class StringMathematicaAdapter : IMathematicaRenderable
    {
        static readonly Dictionary<char, string> Replacements = GenerateReplacements();

        readonly string Value1;

        public StringMathematicaAdapter(string value1)
        {
            Value1 = value1;
        }

        public string RenderMathematica()//TODO: Verify and make complete
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append('"');

            foreach (char char1 in Value1)
            {
                switch (char1)
                {
                    case '"':
                        sb1.Append("\\\"");
                        continue;
                    case '\n':
                        sb1.Append("\\n");
                        continue;
                    case '\\':
                        sb1.Append("\\\\");
                        continue;
                    default:
                        sb1.Append(char1);
                        continue;
                }
            }

            sb1.Append('"');

            return sb1.ToString();
        }

        static Dictionary<char, string> GenerateReplacements()
        {
            var out1 = new Dictionary<char, string>
            {
                {'"', "\\\""},
                {'\n', "\\n"},
                {'\\', "\\\\"}
            };

            return out1;
        }
    }
}
