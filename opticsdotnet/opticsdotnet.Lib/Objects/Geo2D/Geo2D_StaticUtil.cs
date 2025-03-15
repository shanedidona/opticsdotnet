using static opticsdotnet.Lib.MathUtil;

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

        public static Point2D[] LineIntersectCircle(Line2D line2D, Circle2D circle2D)
        {
            Line2DPoint2DDistanceResult line2DPoint2DDistanceResult = LinePointDistanceCalc(
                    line2D.Point0.X,
                    line2D.Point0.Y,
                    line2D.Theta,
                    circle2D.Center.X,
                    circle2D.Center.Y
                );

            double rCircle = circle2D.R;

            if (rCircle < line2DPoint2DDistanceResult.DMin)
            {
                return new Point2D[0];
            }

            if (rCircle == line2DPoint2DDistanceResult.DMin)
            {
                return new Point2D[] { line2DPoint2DDistanceResult.ClosestPoint };
            }

            double x0 = line2D.Point0.X;
            double y0 = line2D.Point0.Y;
            double xc = circle2D.Center.X;
            double yc = circle2D.Center.Y;

            (double sinTheta, double cosTheta) = Math.SinCos(line2D.Theta);

            double firstPart = -x0 * cosTheta + xc * cosTheta - y0 * sinTheta + yc * sinTheta;

            double sqrtTerm = Math.Sqrt(Sq(rCircle) - Sq(x0 - xc) - Sq(y0 - yc) + Sq((x0 - xc) * cosTheta + (y0 - yc) * sinTheta));

            double a1 = firstPart - sqrtTerm;
            double a2 = firstPart + sqrtTerm;

            Point2D point1 = new Point2D(
                    x0 + a1 * cosTheta,
                    y0 + a1 * sinTheta
                );

            Point2D point2 = new Point2D(
                    x0 + a2 * cosTheta,
                    y0 + a2 * sinTheta
                );

            return new Point2D[] { point1, point2 };
        }

        public static Point2D LineIntersectLine(Line2D line1, Line2D line2)
        {
            double angleDiffForTest = Math.Abs(line1.Theta - line2.Theta) / Math.PI;
            angleDiffForTest = angleDiffForTest - Math.Floor(angleDiffForTest);
            angleDiffForTest = angleDiffForTest * Math.PI;

            if (angleDiffForTest < SmallAngle)
            {
                return null;
            }

            double x10 = line1.Point0.X;
            double y10 = line1.Point0.Y;
            double x20 = line2.Point0.X;
            double y20 = line2.Point0.Y;

            double a2Min = -((y10 - y20) * Math.Cos(line1.Theta) + (-x10 + x20) * Math.Sin(line1.Theta)) / Math.Sin(line1.Theta - line2.Theta);

            return new Point2D(
                        line2.Point0.X + a2Min * Math.Cos(line2.Theta),
                        line2.Point0.Y + a2Min * Math.Sin(line2.Theta)
                    );
        }
    }
}
