using static opticsdotnet.Lib.MathUtil;

namespace opticsdotnet.Lib
{
    public sealed class AxiFlatTerminator : IAxiRayTerminator
    {
        public void AxiRayTrace(double thisZ0, AxiDrift previousDrift, AxiRay[] axiRays)
        {
            throw new NotImplementedException();
        }

        public string RenderMathematica()
        {
            return (new Line2D(0, 0, PiOver2)).RenderMathematica();
        }
    }
}
