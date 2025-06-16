namespace opticsdotnet.Lib.Mathematica
{
    public interface IMathematicaRenderableWithDirective : IMathematicaRenderable
    {
        string RenderMathematicaWithDirective(params MathematicaDirective[] mathematicaDirectives);
    }
}
