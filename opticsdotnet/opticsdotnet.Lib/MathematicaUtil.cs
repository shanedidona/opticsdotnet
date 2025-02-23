using System.Text;

namespace opticsdotnet.Lib
{
    public static class MathematicaUtil
    {
        public static string RenderMathematica(params double[] doubles)
        {
            return RenderMathematicaAssumeAlreadyMathematica(doubles.Select(Render).ToArray());
        }

        public static string RenderMathematica(params IMathematicaRenderable[] items)
        {
            return RenderMathematicaAssumeAlreadyMathematica(items.Select(x => x.RenderMathematica()).ToArray());
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

        public static string RenderMathematicaFunction(string name, params IMathematicaRenderable[] args)
        {
            var sb1 = new StringBuilder();
            sb1.Append(name);
            sb1.Append("[");
            sb1.Append(string.Join(",", args.Select(x => x.RenderMathematica())));
            sb1.Append("]");

            return sb1.ToString();
        }
    }
}
