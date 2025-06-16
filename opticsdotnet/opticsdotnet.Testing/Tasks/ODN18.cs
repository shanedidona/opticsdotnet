using opticsdotnet.Lib;
using opticsdotnet.Lib.Mathematica;
using ScottPlot;

namespace opticsdotnet.Testing.ODN18
{
    public static class ODN18
    {
        public static void ODN18_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-18");
            Directory.CreateDirectory(saveDir);

            Random random = new Random(1);
            int n = 50;
            Circle2D[] circles = new Circle2D[n];
            Line2D[] lines = new Line2D[n];
            Point2D[][] intersectionPoints = new Point2D[n][];
            string[] stringsOut = new string[n];
            for (int i = 0; i < n; i++)
            {
                circles[i] = new Circle2D(
                        random.NextInRange(-2, 2),
                        random.NextInRange(-2, 2),
                        random.NextInRange(0.1, 2)
                    );

                lines[i] = new Line2D(
                        random.NextInRange(-5, 5),
                        random.NextInRange(-5, 5),
                        random.NextInRange(-4 * Math.PI, 4 * Math.PI)
                    );

                if (i == 0)
                {
                    circles[i] = new Circle2D(0, 1, 1.5);
                    lines[i] = new Line2D(0, 2, Math.PI / 2);
                }

                if (i == 1)
                {
                    circles[i] = new Circle2D(0, 1, 1.5);
                    lines[i] = new Line2D(1.5,2, Math.PI / 2);
                }

                if (i == 2)
                {
                    circles[i] = new Circle2D(0, 1, 1.5);
                    lines[i] = new Line2D(0.1, 0.2, 0);
                }

                if (i == 3)
                {
                    circles[i] = new Circle2D(0, 1, 1.5);
                    lines[i] = new Line2D(0.1, 0.2, Math.PI * 2);
                }

                if (i == 4)
                {
                    circles[i] = new Circle2D(0, 1, 1.5);
                    lines[i] = new Line2D(0.1, 0.2, Math.PI);
                }

                intersectionPoints[i] = Geo2D.LineIntersectCircle(lines[i], circles[i]);

                var items = new List<IMathematicaRenderable>();
                items.Add(circles[i]);
                items.Add(lines[i]);
                items.AddRange(intersectionPoints[i]);

                stringsOut[i] = new MathematicaRenderableMathematicaAdapter(
                    new MathematicaRenderableMathematicaAdapter(
                            items.ToArray()
                        )
                ).RenderMathematicaFunction("Graphics");
            }

            File.WriteAllLines(Path.Combine(saveDir, "ODN18_1.txt"), stringsOut);
        }
    }
}
