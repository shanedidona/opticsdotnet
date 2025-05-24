using static opticsdotnet.Lib.MathUtil;

namespace opticsdotnet.Lib
{
    public sealed class AxiFlatTerminator : IAxiRayTerminator
    {
        Line2D Flat = new Line2D(0, 0, PiOver2);


        public void AxiRayTrace(double thisZ0, AxiDrift previousDrift, AxiRay[] axiRays)
        {
            foreach (AxiRay axiRay in axiRays)
            {
                AxiRayState currentState = axiRay.GetCurrentState();

                if (!currentState.Theta.HasValue) { return; }

                if (!currentState.Intensity.HasValue) { return; }

                //Relative to the point we care about where this flat intersects the axis
                Line2D incomingLine = new Line2D(currentState.Z0 - thisZ0, currentState.R0, currentState.Theta.Value);





            }











            throw new NotImplementedException();
        }

        public string RenderMathematica()
        {
            return Flat.RenderMathematica();
        }
    }
}
