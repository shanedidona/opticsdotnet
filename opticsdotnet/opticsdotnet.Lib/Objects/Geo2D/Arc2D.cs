namespace opticsdotnet.Lib
{
    public sealed class Arc2D : Geo2D
    {
        public Point2D Center { get; set; }
        public double R { get; set; }
        public double Theta1 { get; set; }
        public double Theta2 { get; set; }


        public Arc2D(double xC, double yC, double r, double theta1, double theta2)
        {
            Center = new Point2D(xC, yC);
            R = r;
            Theta1 = theta1;
            Theta2 = theta2;
        }


        public override string RenderMathematica()
        {
            return new MathematicaRenderableMathematicaAdapter(
                            new MathematicaRenderableMathematicaAdapter(
                                    new DoubleMathematicaAdapter(Center.X),
                                    new DoubleMathematicaAdapter(Center.Y)
                                ),
                            new DoubleMathematicaAdapter(R),
                            new MathematicaRenderableMathematicaAdapter(
                                    new DoubleMathematicaAdapter(Theta1),
                                    new DoubleMathematicaAdapter(Theta2)
                                )
                        ).RenderMathematicaFunction("Circle");
        }
    }
}
