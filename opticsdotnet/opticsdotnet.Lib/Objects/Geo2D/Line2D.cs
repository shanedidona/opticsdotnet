using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Lib
{
    public sealed class Line2D : Geo2D
    {
        public Point2D Point0 { get; set; }
        public double Theta { get; set; }


        public Line2D(double x0, double y0, double theta)
        {
            Point0 = new Point2D(x0, y0);
            Theta = theta;
        }


        public override string RenderMathematica()
        {
            return new MathematicaRenderableMathematicaAdapter(
                    new MathematicaRenderableMathematicaAdapter(
                                                new DoubleMathematicaAdapter(Point0.X),
                                                new DoubleMathematicaAdapter(Point0.Y)
                                            ),
                    new MathematicaRenderableMathematicaAdapter(
                                                new DoubleMathematicaAdapter(Math.Cos(Theta)),
                                                new DoubleMathematicaAdapter(Math.Sin(Theta))
                                            )
                ).RenderMathematicaFunction("InfiniteLine");
        }
    }
}
