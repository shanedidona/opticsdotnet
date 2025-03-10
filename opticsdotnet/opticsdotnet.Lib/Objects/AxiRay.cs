namespace opticsdotnet.Lib
{
    public sealed class AxiRay
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
    }
}
