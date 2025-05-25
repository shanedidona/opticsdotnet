namespace opticsdotnet.Lib
{
    public interface IAxiRayTerminator : IMathematicaRenderable
    {
        public void AxiRayTrace(double thisZ0, AxiDrift previousDrift, IEnumerable<AxiRay> axiRays);
    }
}
