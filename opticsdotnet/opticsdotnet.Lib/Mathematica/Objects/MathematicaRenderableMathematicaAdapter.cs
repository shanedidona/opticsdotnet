﻿using System.Text;

namespace opticsdotnet.Lib.Mathematica
{
    public sealed class MathematicaRenderableMathematicaAdapter : IMathematicaRenderable
    {
        readonly IMathematicaRenderable[] Array1;

        public MathematicaRenderableMathematicaAdapter(params IMathematicaRenderable[] array)
        {
            Array1 = array;
        }

        public string RenderMathematica()
        {
            var sb1 = new StringBuilder();
            sb1.Append("{");
            sb1.Append(string.Join(",", Array1.Select(x => x.RenderMathematica())));
            sb1.Append("}");

            return sb1.ToString();
        }

        public string RenderMathematicaFunction(string name)
        {
            var sb1 = new StringBuilder();
            sb1.Append(name);
            sb1.Append("[");
            sb1.Append(string.Join(",", Array1.Select(x => x.RenderMathematica())));
            sb1.Append("]");

            return sb1.ToString();
        }
    }
}
