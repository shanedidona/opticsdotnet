namespace opticsdotnet.Lib.Objects
{
    public sealed class AxiOpticalSystem : IMathematicaRenderable
    {
        readonly IAxiRaySource AxiRaySource;
        readonly AxiDrift[] Drifts;
        readonly IAxiOpticalElement[] Elements;
        readonly IAxiRayTerminator RayTerminator;





        public string RenderMathematica()
        {
            throw new NotImplementedException();
        }
    }
}
