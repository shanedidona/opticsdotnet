namespace opticsdotnet.Lib
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
            throw new NotImplementedException();
        }
    }
}
