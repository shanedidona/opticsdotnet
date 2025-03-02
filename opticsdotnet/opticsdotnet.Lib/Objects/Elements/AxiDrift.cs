namespace opticsdotnet.Lib
{
    public sealed class AxiDrift : IMathematicaRenderable
    {
        readonly double Length1;
        readonly IOpticalMaterial OpticalMaterial;

        public AxiDrift(IOpticalMaterial opticalMaterial, double length)
        {
            OpticalMaterial = opticalMaterial;
            Length1 = length;
        }

        public string RenderMathematica()
        {
            return MathematicaUtil.Nothing;
        }
    }
}
