namespace opticsdotnet.Lib
{
    public sealed class Circle2D : Geo2D
    {
        public Point2D Center { get; set; }
        public double R { get; set; }

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
