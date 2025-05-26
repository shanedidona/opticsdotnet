namespace opticsdotnet.Lib
{
    public interface IAxiRayTerminator : IMathematicaRenderable
    {
        public IEnumerable<AxiRay> AxiRayTrace(double thisZ0, AxiDrift previousDrift, IEnumerable<AxiRay> axiRays);
    }
}
