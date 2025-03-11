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

            diameters.Add(0.006);
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1116(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1470(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1222(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1700()
            });

            diameters.Add(0.009);
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1576(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1472()
            });

            diameters.Add(0.0127);
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1540(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1074(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1560(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1289(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1304(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1213(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1207()
            });

            diameters.Add(0.018);
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1859(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1270(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1085(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1119()
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
