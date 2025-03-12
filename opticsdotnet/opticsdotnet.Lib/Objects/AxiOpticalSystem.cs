namespace opticsdotnet.Lib.Objects
{
    public sealed class AxiOpticalSystem : IMathematicaRenderable
    {
        readonly IAxiRaySource AxiRaySource;
        readonly AxiDrift[] AxiDrifts;
        readonly IAxiOpticalElement[] AxiElements;
        readonly IAxiRayTerminator AxiRayTerminator;

        public AxiOpticalSystem(
                IAxiRaySource axiRaySource,
                AxiDrift[] axiDrifts,
                IAxiOpticalElement[] axiElements,
                IAxiRayTerminator axiRayTerminator
            )
        {
            AxiRaySource = axiRaySource;
            AxiDrifts = axiDrifts;
            AxiElements = axiElements;
            AxiRayTerminator = axiRayTerminator;

            if (axiDrifts.Length < 1)
            {
                throw new NotSupportedException("There must be at least one IAxiDrift");
            }

            if (axiDrifts.Length != (axiElements.Length + 1))
            {
                throw new NotSupportedException("axiDrifts.Length != (axiElements.Length + 1)");
            }
        }

        public string RenderMathematica()
        {
            throw new NotImplementedException();
        }
    }
}
