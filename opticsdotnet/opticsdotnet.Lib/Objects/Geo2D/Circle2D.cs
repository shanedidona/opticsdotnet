namespace opticsdotnet.Lib
{
    public sealed class Circle2D : Geo2D
    {
        public Point2D Center { get; set; }
        public double R { get; set; }


        public Circle2D(double xC, double yC, double r)
        {
            Center = new Point2D(xC, yC);
            R = r;
        }

        public Arc2D GetArc(double theta1, double theta2)
        {
            return new Arc2D(Center.X, Center.Y, R, theta1, theta2);
        }


        public override string RenderMathematica()
        {
            return new MathematicaRenderableMathematicaAdapter(
                            new MathematicaRenderableMathematicaAdapter(
                                    new DoubleMathematicaAdapter(Center.X),
                                    new DoubleMathematicaAdapter(Center.Y)
                                ),
                            new DoubleMathematicaAdapter(R)
                        ).RenderMathematicaFunction("Circle");
        }
    }
}
