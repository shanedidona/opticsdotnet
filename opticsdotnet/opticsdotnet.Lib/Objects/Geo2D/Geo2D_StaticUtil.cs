namespace opticsdotnet.Lib
{
    public abstract partial class Geo2D : IMathematicaRenderable
    {
        public static Line2DPoint2DDistanceResult LinePointDistanceCalc(double x0, double y0, double theta, double xp, double yp)
        {
            double aMin = (-x0 + xp) * Math.Cos(theta) + (-y0 + yp) * Math.Sin(theta);

            double dMin = Math.Abs((y0 - yp) * Math.Cos(theta) + (-x0 + xp) * Math.Sin(theta));

            Point2D closestPoint = new Point2D(
                        x0 + aMin * Math.Cos(theta),
                        y0 + aMin * Math.Sin(theta)
                    );

            return new Line2DPoint2DDistanceResult()
            {
                AMin = aMin,
                DMin = dMin,
                ClosestPoint = closestPoint
            };
        }
    }
}
