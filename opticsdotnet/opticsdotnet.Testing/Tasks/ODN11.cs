using opticsdotnet.Lib;

namespace opticsdotnet.Testing.ODN11
{
    public static class ODN11
    {
        public static void ODN11_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-11");
            Directory.CreateDirectory(saveDir);

            var axiLenses = new List<AxiLens>();

            axiLenses.Add(
                    new AxiLens(
                         new NBK7(),
                         0.02,
                         0.05,
                         0.3,
                         0.4
                    )
                );

            string[] linesOut = axiLenses.Select(axiLens =>
                    new MathematicaRenderableMathematicaAdapter(axiLens).RenderMathematicaFunction("Graphics")

                ).ToArray();

            File.WriteAllLines(Path.Combine(saveDir, "ODN11_1.txt"), linesOut);

















            //File.WriteAllText(Path.Combine(saveDir, "ODN11_1.txt"), axiLens.RenderMathematica());







            return;


















            var nbk7 = new NBK7();
            var v1 = nbk7.AbsorptionCoefficient(400);
            var v2 = nbk7.AbsorptionCoefficient(-400);

            PhysicsUtil.OpticalMaterialPlot(nbk7, Path.Combine(saveDir, "ODN9_1.png"), 1000);


        }
    }
}
