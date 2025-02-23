namespace opticsdotnet.Lib
{
    public sealed class Point2D : Geo2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override string RenderMathematica()
        {
            return new MathematicaRenderableMathematicaAdapter(
                    new MathematicaRenderableMathematicaAdapter(
                                    new DoubleMathematicaAdapter(X),
                                    new DoubleMathematicaAdapter(Y)
                                )
                    ).RenderMathematicaFunction("Point");
        }
    }
}
