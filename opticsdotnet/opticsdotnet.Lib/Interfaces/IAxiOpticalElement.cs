namespace opticsdotnet.Lib
{
    public interface IAxiOpticalElement : IMathematicaRenderable
    {
        public double CenterLength { get; }

        public void AxiRayTrace(double thisZ0, AxiDrift previousDrift, AxiDrift nextDrift, AxiRay[] axiRays);//TODO: support total internal reflection
    }
}
