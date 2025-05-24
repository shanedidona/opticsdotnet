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
            return (new Line2D(0, 0, Math.PI / 2)).RenderMathematica();
        }
    }
}
