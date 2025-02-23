using opticsdotnet.Lib;

namespace opticsdotnet.Testing.ODN1
{
    public static class ODN1
    {
        public static void ODN1_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-1");
            Directory.CreateDirectory(saveDir);

            string string1 = MathematicaUtil.RenderMathematicaFunction(
                    "Graphics",
                    (new Circle2D() { Center = new Point2D() { X = 2, Y = 3 }, R = 2 }).RenderMathematica(),
                    (new LineSegment2D() { X1 = 2, Y1 = 3, X2 = 4, Y2 = 3.4 }).RenderMathematica(),
                    (new Point2D() { X = 1, Y = 2}).RenderMathematica()
                );

            File.WriteAllText(Path.Combine(saveDir, "ODN1_1.txt"), string1);


        }
    }
}
