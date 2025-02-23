using opticsdotnet.Lib;

namespace opticsdotnet.Testing.ODN1
{
    public static class ODN1
    {
        public static void ODN1_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-1");
            Directory.CreateDirectory(saveDir);

            Circle2D circle2D = new Circle2D(2, 3, 2);
            LineSegment2D lineSegment2D = new LineSegment2D(2, 3, 4, 3.4);
            Point2D point2D = new Point2D(1, 2);
            Line2D line2D = new Line2D(1, 0, 0.1);

            string string1 = new MathematicaRenderableMathematicaAdapter(
                    new MathematicaRenderableMathematicaAdapter(
                            circle2D, lineSegment2D, point2D, line2D
                        )
                ).RenderMathematicaFunction("Graphics");

            File.WriteAllText(Path.Combine(saveDir, "ODN1_1.txt"), string1);
        }
    }
}
