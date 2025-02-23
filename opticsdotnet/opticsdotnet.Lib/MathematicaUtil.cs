namespace opticsdotnet.Lib
{
    public static class MathematicaUtil
    {
        public static string RenderMathematica(double double1)
        {
            return double1.ToString().Replace("E", "*10^");   
        }
    }
}
