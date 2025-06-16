using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Lib
{
    public sealed class AxiRay : IMathematicaRenderable
    {
        readonly List<AxiRayState> States;

        public AxiRay(AxiRayState initialState)
        {
            States = new List<AxiRayState>() { initialState };
        }

        public AxiRayState GetCurrentState()
        {
            return States.Last();
        }

        public void AddRange(params AxiRayState[] statesToAdd)
        {
            States.AddRange(statesToAdd);
        }

        public string RenderMathematica()
        {
            return new PolyLine2D(
                                        States.Select(
                                            state => new Point2D(state.Z0, state.R0)
                                        ).ToArray()
                                    ).RenderMathematica();
        }
    }
}
