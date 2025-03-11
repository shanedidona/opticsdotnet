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

            diameters.Add(0.025);
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1252(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1255(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1257(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1251(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1253()
            });

            diameters.Add(0.0254);
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1951(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1805(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1027(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1422(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1131(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1134(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1608(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1509(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1986(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1433(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1229(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1708(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1461(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1484(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1172(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1908(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1978(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1464(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1254(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1258(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1259()
            });

            diameters.Add(0.030);
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1274(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1102(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1765(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1031(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1907(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1541(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1832(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1419(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1237()
            });

            diameters.Add(0.0381);
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1385(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1386(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1387(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1388(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1389()
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
