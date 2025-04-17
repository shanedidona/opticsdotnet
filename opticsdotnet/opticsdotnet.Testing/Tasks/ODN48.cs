using opticsdotnet.Lib;

namespace opticsdotnet.Testing.ODN48
{
    public static class ODN48
    {
        public static void ODN48_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-48");
            Directory.CreateDirectory(saveDir);

            Random random = new Random(1);
            int maxNumLines = 10;
            int numRuns = 100;
            var linesOut = new List<string>();
            for (int runI = 0; runI < numRuns; runI++)
            {
                var mathematicaRenderables = new List<IMathematicaRenderable>();

                int numLines = random.Next(1, maxNumLines + 1);
                Line2D[] lines = new Line2D[numLines];
                for (int lineI = 0; lineI < numLines; lineI++)
                {
                    double thetaAbsRange = 30;

                    lines[lineI] = new Line2D(random.NextInRange(-2, 2), random.NextInRange(-2, 2), random.NextInRange(-thetaAbsRange, thetaAbsRange));
                    mathematicaRenderables.Add(lines[lineI]);
                    mathematicaRenderables.Add(lines[lineI].Point0);
                }

                Point2D closestPointToLines = Geo2D.ClosestPointToLines(lines);

                if (closestPointToLines != null)
                {
                    mathematicaRenderables.Add(closestPointToLines);
                }

                linesOut.Add(new MathematicaRenderableMathematicaAdapter(mathematicaRenderables.ToArray()).RenderMathematica());
            }

            File.WriteAllLines(Path.Combine(saveDir, "ODN48_1.txt"), linesOut);
        }
    }
}
