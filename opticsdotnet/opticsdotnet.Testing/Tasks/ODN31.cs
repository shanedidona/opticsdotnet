using opticsdotnet.Lib;

namespace opticsdotnet.Testing.ODN31
{
    public static class ODN31
    {
        public static void ODN31_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-31");
            Directory.CreateDirectory(saveDir);

            Random random = new Random(1);
            int n = 10;
            Point2D[] points = new Point2D[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = new Point2D(random.NextInRange(-2, 2), random.NextInRange(-2, 2));
            }

            PolyLine2D polyLine2D = new PolyLine2D(points);

            string string1 = polyLine2D.RenderMathematica();

            File.WriteAllText(Path.Combine(saveDir, "ODN1_31.txt"), string1);
        }
    }
}
