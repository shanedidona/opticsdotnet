namespace opticsdotnet.Lib.Mathematica
{
    public sealed class AlreadyMathematicaRenderedMathematicaAdapter : IMathematicaRenderable
    {
        readonly string RenderedString;

        public AlreadyMathematicaRenderedMathematicaAdapter(string renderedString)
        {
            RenderedString = renderedString;
        }

        public string RenderMathematica()
        {
            return RenderedString;
        }
    }
}
