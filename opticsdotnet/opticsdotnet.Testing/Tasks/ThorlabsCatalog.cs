using opticsdotnet.Lib;

namespace opticsdotnet.Testing.ThorlabsCatalog
{
    public static class ThorlabsCatalog
    {
        public static void ThorlabsCatalog_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ThorlabsCatalog");
            Directory.CreateDirectory(saveDir);

            var diameters = new List<double>();
            var lenses = new List<AxiLens[]>();

            diameters.Add(0.002);
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1024(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1026()
            });

            diameters.Add(0.003);
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1036(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1039()
            });

            for (int i = 0; i < diameters.Count; i++)
            {
                var linesOut = new List<string>();
                linesOut.Add(new DoubleMathematicaAdapter(diameters[i]).RenderMathematica());

                foreach (AxiLens axiLens in lenses[i])
                {
                    linesOut.Add(new MathematicaRenderableMathematicaAdapter(axiLens).RenderMathematicaFunction("Graphics"));
                }

                File.WriteAllLines(Path.Combine(saveDir, diameters[i].ToString() + ".txt"), linesOut);
            }
        }
    }
}
