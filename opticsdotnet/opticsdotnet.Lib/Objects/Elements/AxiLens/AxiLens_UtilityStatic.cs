namespace opticsdotnet.Lib
{
    public sealed partial class AxiLens : IAxiOpticalElement
    {
        static void AxiRayTraceCircle(
                AxiRay axiRay,
                double? nLeft,
                double? nRight,
                Circle2D circle,
                bool openingRight,//For left surface this means convex, for right surface this means concave
                double circleIntersectionWithAxis,//The intersection that the circle makes with the axis for the part that we care about
                double outerRadius
            )
        {
            AxiRayState currentState = axiRay.GetCurrentState();

            if (!currentState.Theta.HasValue) { continue; }

            if (!currentState.Intensity.HasValue) { continue; }











        }
    }
}