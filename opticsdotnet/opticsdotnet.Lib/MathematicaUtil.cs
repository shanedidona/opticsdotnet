using System.Text;

namespace opticsdotnet.Lib
{
    public static class MathematicaUtil
    {
        public static string RenderMathematica(double double1)
        {
            return double1.ToString().Replace("E", "*10^");   
        }

        public static string RenderMathematica(IEnumerable<double> doubles)
        {
            return RenderMathematicaAssumeAlreadyMathematica(doubles.Select(RenderMathematica));
        }

        public static string RenderMathematicaAssumeAlreadyMathematica(IEnumerable<string> renderedItems)
        {
            var sb1 = new StringBuilder();
            sb1.Append("{");
            sb1.Append(string.Join(",", renderedItems));
            sb1.Append("}");

            return sb1.ToString();
        }
    }
}
