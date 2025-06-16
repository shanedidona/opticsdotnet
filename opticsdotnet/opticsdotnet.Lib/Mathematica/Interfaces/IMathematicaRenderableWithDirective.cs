namespace opticsdotnet.Lib.Mathematica
{
    public interface IMathematicaRenderableWithDirective
    {
        string RenderMathematicaWithDirective(params MathematicaDirective[] mathematicaDirectives);
    }
}
