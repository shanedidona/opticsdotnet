namespace opticsdotnet.Lib
{
    public sealed class AxiFlatTerminator : IAxiRayTerminator
    {
        public string RenderMathematica()
        {
            return (new Line2D(0, 0, Math.PI / 2)).RenderMathematica();
        }
    }
}
