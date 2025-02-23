using System.Text;

namespace opticsdotnet.Lib
{
    public static class MathematicaUtil
    {
        public static string RenderMathematica(double double1)
        {
            return double1.ToString().Replace("E", "*10^");   
        }

        public static string RenderMathematica(params double[] doubles)
        {
            return RenderMathematicaAssumeAlreadyMathematica(doubles.Select(RenderMathematica));
        }

        public static string RenderMathematicaAssumeAlreadyMathematica(params string[] renderedItems)
        {
            var sb1 = new StringBuilder();
            sb1.Append("{");
            sb1.Append(string.Join(",", renderedItems));
            sb1.Append("}");

            return sb1.ToString();
        }

        public static string RenderMathematicaFunction(string name, params string[] args)
        {
            var sb1 = new StringBuilder();
            sb1.Append(name);
            sb1.Append("[");
            sb1.Append(string.Join(",", args));
            sb1.Append("]");

            return sb1.ToString();
        }
    }
}
