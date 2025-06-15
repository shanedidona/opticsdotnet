using opticsdotnet.Lib;
using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Testing.ODN11
{
    public static class ODN11
    {
        public static void ODN11_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-11");
            Directory.CreateDirectory(saveDir);

            var sphericalSinglets = new List<SphericalSinglet>();

            sphericalSinglets.Add(
                    new SphericalSinglet(
                         new NBK7(),
                         0.02,
                         0.05,
                         0.3,
                         0.4
                    )
                );

            sphericalSinglets.Add(
                    new SphericalSinglet(
                         new NBK7(),
                         0.02,
                         0.05,
                         -0.3,
                         0.4
                    )
                );

            sphericalSinglets.Add(
                    new SphericalSinglet(
                         new NBK7(),
                         0.02,
                         0.05,
                         0.3,
                         -0.4
                    )
                );

            sphericalSinglets.Add(
                    new SphericalSinglet(
                         new NBK7(),
                         0.02,
                         0.05,
                         -0.3,
                         -0.4
                    )
                );

            sphericalSinglets.Add(
                    new SphericalSinglet(
                         new NBK7(),
                         0.02,
                         0.05,
                         null,
                         null
                    )
                );

            string[] linesOut = sphericalSinglets.Select(sphericalSinglet =>
                    new MathematicaRenderableMathematicaAdapter(sphericalSinglet).RenderMathematicaFunction("Graphics")

                ).ToArray();

            File.WriteAllLines(Path.Combine(saveDir, "ODN11_1.txt"), linesOut);
        }
    }
}
