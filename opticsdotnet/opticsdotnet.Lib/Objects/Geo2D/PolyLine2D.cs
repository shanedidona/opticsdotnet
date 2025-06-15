using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Lib
{
    public sealed class PolyLine2D : Geo2D
    {
        readonly double[] Xs;
        readonly double[] Ys;


        public PolyLine2D(params Point2D[] points)
        {
            Xs = new double[points.Length];
            Ys = new double[points.Length];

            for (int i = 0; i < points.Length; i++)
            {
                Xs[i] = points[i].X;
                Ys[i] = points[i].Y;
            }
        }

        public override string RenderMathematica()
        {

            var innerPart = new MathematicaRenderableMathematicaAdapter[Xs.Length];
            for (int i = 0; i < Xs.Length; i++)
            {
                innerPart[i] = new MathematicaRenderableMathematicaAdapter(
                                                new DoubleMathematicaAdapter(Xs[i]),
                                                new DoubleMathematicaAdapter(Ys[i])
                                            );
            }

            return new MathematicaRenderableMathematicaAdapter(
                        new MathematicaRenderableMathematicaAdapter(innerPart)
                        ).RenderMathematicaFunction("Line");
        }
    }
}
