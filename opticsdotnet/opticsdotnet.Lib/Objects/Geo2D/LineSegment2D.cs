namespace opticsdotnet.Lib
{
    public sealed class LineSegment2D : Geo2D
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }


        public override string RenderMathematica()
        {
            return new MathematicaRenderableMathematicaAdapter(
                        new MathematicaRenderableMathematicaAdapter(
                            new MathematicaRenderableMathematicaAdapter(
                                                new DoubleMathematicaAdapter(X1),
                                                new DoubleMathematicaAdapter(Y1)
                                            ),
                            new MathematicaRenderableMathematicaAdapter(
                                                new DoubleMathematicaAdapter(X2),
                                                new DoubleMathematicaAdapter(Y2)
                                            )
                                )
                        ).RenderMathematicaFunction("Line");
        }
    }
}
