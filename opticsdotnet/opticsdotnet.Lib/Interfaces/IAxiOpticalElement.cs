using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Lib
{
    public interface IAxiOpticalElement : IMathematicaRenderable
    {
        public double CenterLength { get; }

        public IEnumerable<AxiRay> AxiRayTrace(double thisZ0, AxiDrift previousDrift, AxiDrift nextDrift, IEnumerable<AxiRay> axiRays);//TODO: support total internal reflection

        public AxiRay AxiRayTraceSingleRay(double thisZ0, AxiDrift previousDrift, AxiDrift nextDrift, AxiRay axiRay);//TODO: support total internal reflection
    }
}
