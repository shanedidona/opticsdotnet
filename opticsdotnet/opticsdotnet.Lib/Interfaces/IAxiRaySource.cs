using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Lib
{
    public interface IAxiRaySource : IMathematicaRenderable
    {
        public IEnumerable<AxiRay> AxiRays();
    }
}
