namespace opticsdotnet.Lib
{
    public sealed class AxiDrift : IMathematicaRenderable
    {
        readonly double Length1;

        public AxiDrift(double length)
        {
            Length1 = length;
        }

        public string RenderMathematica()
        {
            return MathematicaUtil.Nothing;
        }
    }
}
