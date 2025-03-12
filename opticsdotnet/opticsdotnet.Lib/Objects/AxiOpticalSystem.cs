namespace opticsdotnet.Lib.Objects
{
    public sealed class AxiOpticalSystem : IMathematicaRenderable
    {
        readonly IAxiRaySource AxiRaySource;
        readonly AxiDrift[] AxiDrifts;
        readonly IAxiOpticalElement[] AxiElements;
        readonly IAxiRayTerminator AxiRayTerminator;





        public string RenderMathematica()
        {
            throw new NotImplementedException();
        }
    }
}
