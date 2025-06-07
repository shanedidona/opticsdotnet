namespace opticsdotnet.Lib
{
    public sealed class AxiOpticalAssembly : IMathematicaRenderable
    {
        readonly AxiDrift[] AxiDrifts;
        readonly IAxiOpticalElement[] AxiElements;

        readonly int NumOpticalElements;
        readonly double[] AxiElementOffsets;


        public AxiOpticalAssembly(
                AxiDrift[] axiDrifts,
                IAxiOpticalElement[] axiElements
            )
        {
            AxiDrifts = axiDrifts;
            AxiElements = axiElements;

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
        }

        public IMathematicaRenderable[] GetMathematicaRenderables()
        {
            var objectsToRender = new List<IMathematicaRenderable>();
            var offsetsForRender = new List<double[]>();

            for (int i = 0; i < NumOpticalElements; i++)
            {
                objectsToRender.Add(AxiElements[i]);
                offsetsForRender.Add(new double[] { AxiElementOffsets[i], 0 });
            }

            var mathematicaRenderables = new List<IMathematicaRenderable>();
            for (int i = 0; i < objectsToRender.Count; i++)
            {
                var renderableOffset = new MathematicaRenderableMathematicaAdapter(
                            new DoubleMathematicaAdapter(offsetsForRender[i][0]),
                            new DoubleMathematicaAdapter(offsetsForRender[i][1])
                        );

                string renderedTranslated = new MathematicaRenderableMathematicaAdapter(objectsToRender[i], renderableOffset).RenderMathematicaFunction("Translate");

                mathematicaRenderables.Add(new AlreadyMathematicaRenderedMathematicaAdapter(renderedTranslated));
            }

            return mathematicaRenderables.ToArray();
        }






        public string RenderMathematica()
        {
            return new MathematicaRenderableMathematicaAdapter(GetMathematicaRenderables()).RenderMathematica();
        }
    }
}
