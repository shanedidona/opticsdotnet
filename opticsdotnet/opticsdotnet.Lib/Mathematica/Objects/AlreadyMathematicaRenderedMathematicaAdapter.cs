using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Lib
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
