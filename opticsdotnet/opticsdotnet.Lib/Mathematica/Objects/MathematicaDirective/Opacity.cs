namespace opticsdotnet.Lib.Mathematica
{
    public sealed class Opacity : MathematicaDirective
    {
        readonly double A;

        public Opacity(double a)
        {
            A = a;
        }

        public override string RenderMathematica()
        {
            return (new MathematicaRenderableMathematicaAdapter(
                    new DoubleMathematicaAdapter(A)
                )).RenderMathematicaFunction("Opacity");
        }
    }
}
