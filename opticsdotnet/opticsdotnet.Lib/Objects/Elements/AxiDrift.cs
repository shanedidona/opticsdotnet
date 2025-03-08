namespace opticsdotnet.Lib
{
    public sealed class AxiDrift : IAxiOpticalElement
    {
        readonly double Length1;
        readonly IOpticalMaterial OpticalMaterial;

        public AxiDrift(IOpticalMaterial opticalMaterial, double length)
        {
            OpticalMaterial = opticalMaterial;
            Length1 = length;
        }

        public double CenterLength => Length1;

        public string RenderMathematica()
        {
            return MathematicaUtil.Nothing;
        }
    }
}
