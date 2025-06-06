namespace opticsdotnet.Lib
{
    public sealed class AxiOpticalAssembly : IMathematicaRenderable
    {
        readonly AxiDrift[] AxiDrifts;
        readonly IAxiOpticalElement[] AxiElements;

        readonly int NumOpticalElements;
        readonly double[] AxiElementOffsets;


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

            NumOpticalElements = AxiElements.Length;
            AxiElementOffsets = new double[NumOpticalElements];

            for (int i = 0; i < NumOpticalElements; i++)
            {
                if (i == 0)
                {
                    AxiElementOffsets[0] = AxiDrifts[0].Length1;
                }
                else
                {
                    AxiElementOffsets[i] = AxiElementOffsets[i - 1] + AxiElements[i - 1].CenterLength + AxiDrifts[i].Length1;
                }
            }

            AxiRayTerminatorOffset = AxiElementOffsets.Last() + AxiDrifts.Last().Length1;
        }




















        public string RenderMathematica()
        {
            throw new NotImplementedException();
        }
    }
}
