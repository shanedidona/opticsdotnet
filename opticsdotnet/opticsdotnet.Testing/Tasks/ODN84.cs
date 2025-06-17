using opticsdotnet.Lib;
using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Testing.ODN84
{
    public static class ODN84
    {
        public static void ODN84_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-84");
            Directory.CreateDirectory(saveDir);

            Circle2D circle = new Circle2D(1, 2, 3);

            var lines = new List<string>();
            lines.Add(circle.RenderMathematica());
            lines.Add(circle.RenderMathematicaWithDirectives());
            lines.Add(circle.RenderMathematicaWithDirectives(new RGBColor(0.5, 0.1, 0.2)));
            lines.Add(circle.RenderMathematicaWithDirectives(new RGBColor(0.5, 0.1, 0.2, 0.5)));
            lines.Add(circle.RenderMathematicaWithDirectives(new Opacity(1)));
            lines.Add(circle.RenderMathematicaWithDirectives(new Opacity(0.1)));
            lines.Add(circle.RenderMathematicaWithDirectives(new RGBColor(0.5, 0.1, 0.2, 0.5), new Opacity(0.5)));

            File.WriteAllLines(Path.Combine(saveDir, "ODN-84.txt"), lines);
        }
    }
}
