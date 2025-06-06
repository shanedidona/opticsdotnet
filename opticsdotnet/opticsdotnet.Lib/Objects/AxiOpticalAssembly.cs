namespace opticsdotnet.Lib
{
    public sealed class AxiOpticalAssembly : IMathematicaRenderable
    {
        readonly AxiDrift[] AxiDrifts;
        readonly IAxiOpticalElement[] AxiElements;

        readonly int NumOpticalElements;
        readonly double[] AxiElementOffsets;























        public string RenderMathematica()
        {
            throw new NotImplementedException();
        }
    }
}
