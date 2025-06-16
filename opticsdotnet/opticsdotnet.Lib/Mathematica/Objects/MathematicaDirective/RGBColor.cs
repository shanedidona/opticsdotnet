namespace opticsdotnet.Lib.Mathematica
{
    public sealed class RGBColor : MathematicaDirective
    {
        readonly double R;
        readonly double G;
        readonly double B;
        readonly double A;

        public RGBColor(double r, double g, double b, double a = 1.0)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public override string RenderMathematica()
        {
            return (new MathematicaRenderableMathematicaAdapter(
                    new DoubleMathematicaAdapter(R),
                    new DoubleMathematicaAdapter(G),
                    new DoubleMathematicaAdapter(B),
                    new DoubleMathematicaAdapter(A)
                )).RenderMathematicaFunction("RGBColor");
        }
    }
}
