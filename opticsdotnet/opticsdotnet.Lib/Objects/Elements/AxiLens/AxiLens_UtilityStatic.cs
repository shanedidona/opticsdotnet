namespace opticsdotnet.Lib
{
    public sealed partial class AxiLens : IAxiOpticalElement
    {
        public static void AxiRayTraceCircle(
                AxiRay axiRay,
                double? nLeft,
                double? nRight,
                double circleRadius,
                bool openingRight,//For left surface this means convex, for right surface this means concave
                double circleIntersectionWithAxisAbsolute,//The intersection that the circle makes with the axis for the part that we care about, in absolute coords, not relative to the axi lens
                double outerRadius
            )
        {
            if (circleRadius <= 0)
            {
                throw new NotSupportedException();
            }

            AxiRayState currentState = axiRay.GetCurrentState();

            if (!currentState.Theta.HasValue) { return; }

            if (!currentState.Intensity.HasValue) { return; }

            //Relative to the point we care about where this circle intersects the axis
            Line2D line2DRelToAxiIntercept = new Line2D(currentState.Z0 - circleIntersectionWithAxisAbsolute, currentState.R0, currentState.Theta.Value);

            Point2D[] intersectionPoints = Geo2D.LineIntersectCircle(line2DRelToAxiIntercept, new Circle2D(,0,circleRadius));









        }
    }
}