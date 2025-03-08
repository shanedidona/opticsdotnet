namespace opticsdotnet.Lib
{
    public sealed class Point2D : Geo2D
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }


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

    public static class Point2D_Extensions
    {
        public static Point2D TopMost(this Point2D[] points)
        {
            return points.OrderBy(point => point.Y).Last();
        }

        public static Point2D BottomMost(this Point2D[] points)
        {
            return points.OrderBy(point => point.Y).First();
        }

        public static Point2D LeftMost(this Point2D[] points)
        {
            return points.OrderBy(point => point.X).First();
        }

        public static Point2D RightMost(this Point2D[] points)
        {
            return points.OrderBy(point => point.X).Last();
        }
    }
}
