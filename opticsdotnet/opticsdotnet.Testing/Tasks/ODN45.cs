using opticsdotnet.Lib;
using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Testing.ODN45
{
    public static class ODN45
    {
        public static void ODN45_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-45");
            Directory.CreateDirectory(saveDir);

            Random random = new Random(1);
            int n = 100;
            Line2D[] lines1 = new Line2D[n];
            Line2D[] lines2 = new Line2D[n];
            Point2D[] intersectPoints = new Point2D[n];
            string[] linesOut = new string[n];
            for (int i = 0; i < n; i++)
            {
                lines1[i] = new Line2D(random.NextInRange(-2, 2), random.NextInRange(-2, 2), random.NextInRange(-10, 10));
                lines2[i] = new Line2D(random.NextInRange(-2, 2), random.NextInRange(-2, 2), random.NextInRange(-10, 10));

                if (i == 0)
                {
                    lines1[i] = new Line2D(0.5, 0.3, 2.0);
                    lines2[i] = new Line2D(0.5, 0.3, 2.0);
                }

                if (i == 1)
                {
                    lines1[i] = new Line2D(0.5, 0.3, 2.0);
                    lines2[i] = new Line2D(0.4, 0.2, 2.0);
                }

                if (i == 2)
                {
                    lines1[i] = new Line2D(0.5, 0.3, 2.0);
                    lines2[i] = new Line2D(0.4, 0.2, 2.0 - Math.PI);
                }

                intersectPoints[i] = Geo2D.LineIntersectLine(lines1[i], lines2[i]);

                var geo2Ds = new List<Geo2D>()
                {
                    lines1[i],lines2[i]
                };

                if (intersectPoints[i] != null)
                {
                    geo2Ds.Add(intersectPoints[i]);
                }

                linesOut[i] = new MathematicaRenderableMathematicaAdapter(new MathematicaRenderableMathematicaAdapter(geo2Ds.ToArray())).RenderMathematicaFunction("Graphics");
            }

            File.WriteAllLines(Path.Combine(saveDir, "ODN45_1.txt"), linesOut);
        }
    }
}
