using opticsdotnet.Lib;
using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Testing.ODN7
{
    public static class ODN7
    {
        public static void ODN7_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-7");
            Directory.CreateDirectory(saveDir);

            Point2D point2D = new Point2D(1, 2);
            Line2D line2D = new Line2D(1, 0, 0.1);

            Line2DPoint2DDistanceResult line2DPoint2DDistanceResult = Geo2D.LinePointDistanceCalc(
                    line2D.Point0.X,
                    line2D.Point0.Y,
                    line2D.Theta,
                    point2D.X,
                    point2D.Y
                );

            LineSegment2D shortestLine = new LineSegment2D(
                    line2DPoint2DDistanceResult.ClosestPoint.X,
                    line2DPoint2DDistanceResult.ClosestPoint.Y,
                    point2D.X,
                    point2D.Y
                );

            string string1 = new MathematicaRenderableMathematicaAdapter(
                    new MathematicaRenderableMathematicaAdapter(
                            point2D, line2D, shortestLine
                        )
                ).RenderMathematicaFunction("Graphics");

            File.WriteAllText(Path.Combine(saveDir, "ODN7_1.txt"), string1);
        }
    }
}
