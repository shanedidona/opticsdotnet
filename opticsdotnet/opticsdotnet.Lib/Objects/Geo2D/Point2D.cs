namespace opticsdotnet.Lib
{
    public sealed class Point2D : Geo2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override string RenderMathematica()
        {
            return MathematicaUtil.RenderMathematicaFunction("Point", MathematicaUtil.Render(X, Y));
        }
    }
}
