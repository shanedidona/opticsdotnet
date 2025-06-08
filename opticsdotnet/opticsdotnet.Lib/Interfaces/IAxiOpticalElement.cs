namespace opticsdotnet.Lib
{
    public interface IAxiOpticalElement : IMathematicaRenderable
    {
        public double CenterLength { get; }

        public IEnumerable<AxiRay> AxiRayTrace(double thisZ0, AxiDrift previousDrift, AxiDrift nextDrift, IEnumerable<AxiRay> axiRays);//TODO: support total internal reflection

        public IEnumerable<AxiRay> AxiRayTrace(double thisZ0, AxiDrift previousDrift, AxiDrift nextDrift, IEnumerable<AxiRay> axiRays);//TODO: support total internal reflection
    }
}
