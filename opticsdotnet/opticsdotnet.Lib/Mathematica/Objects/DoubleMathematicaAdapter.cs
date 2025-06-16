namespace opticsdotnet.Lib.Mathematica
{
    public sealed class DoubleMathematicaAdapter : IMathematicaRenderable
    {
        readonly double Value1;

        public DoubleMathematicaAdapter(double value1)
        {
            Value1 = value1;
        }

        public string RenderMathematica()
        {
            return Value1.ToString().Replace("E", "*10^");
        }
    }
}
