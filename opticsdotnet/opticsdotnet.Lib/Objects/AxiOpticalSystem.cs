namespace opticsdotnet.Lib
{
    public sealed class AxiOpticalSystem : IMathematicaRenderable
    {
        readonly IAxiRaySource AxiRaySource;
        readonly AxiOpticalAssembly AxiOpticalAssembly1;
        readonly IAxiRayTerminator AxiRayTerminator;

        AxiRay[] AxiRays;
        AxiRay[] AxiRaysAtTerminator;

        public AxiOpticalSystem(
                IAxiRaySource axiRaySource,
                AxiDrift[] axiDrifts,
                IAxiOpticalElement[] axiElements,
                IAxiRayTerminator axiRayTerminator
            )
        {
            AxiRaySource = axiRaySource;
            AxiOpticalAssembly1 = new AxiOpticalAssembly(axiDrifts, axiElements);
            AxiRayTerminator = axiRayTerminator;
        }

        public void RayTrace()
        {
            if (AxiRays != null)
            {
                throw new NotSupportedException("AxiRays != null");
            }

            AxiRays = AxiRaySource.AxiRays().ToArray();

            AxiRaysAtTerminator = AxiRayTerminator.AxiRayTrace(
                    AxiOpticalAssembly1.AxiRayTerminatorOffset,
                    AxiOpticalAssembly1.LastAxiDrift,
                    AxiOpticalAssembly1.RayTrace(AxiRays)
                )
                .Where(axiRay => axiRay.GetCurrentState().IsLive)
                .ToArray();
        }

        public Line2D[] LinesOut()//TODO: this might be removed very soon
        {
            return AxiRays
                .Select(axiRay => axiRay.GetCurrentState())
                .Select(axiRayState => new Line2D(axiRayState.Z0, axiRayState.R0, axiRayState.Theta.Value))
                .ToArray();
        }


        public string RenderMathematica()
        {
            var objectsToRender = new List<IMathematicaRenderable>();
            var offsetsForRender = new List<double[]>();

            objectsToRender.Add(AxiRaySource);
            offsetsForRender.Add(new double[] { 0, 0 });

            objectsToRender.Add(AxiRayTerminator);
            offsetsForRender.Add(new double[] { AxiOpticalAssembly1.AxiRayTerminatorOffset, 0 });

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












            if (AxiRays != null)
            {
                foreach (AxiRay axiRay in AxiRays)
                {
                    mathematicaRenderables.Add(axiRay);
                }
            }

            return new MathematicaRenderableMathematicaAdapter(mathematicaRenderables.ToArray()).RenderMathematica();
        }
    }
}
