using opticsdotnet.Lib;
using static opticsdotnet.Lib.Vendors.Thorlabs.Catalog;

namespace opticsdotnet.Testing.ThorlabsCatalog
{
    public static class ThorlabsCatalog
    {
        public static void ThorlabsCatalog_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ThorlabsCatalog");
            Directory.CreateDirectory(saveDir);

            var sections = new List<string>();
            var lenses = new List<AxiLens[]>();

            string prefix = "N-BK7 Plano-Convex Lenses Uncoated ";

            sections.Add(prefix + "2mm Dia");
            lenses.Add([
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1024(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1026()
            ]);

            sections.Add(prefix + "3mm Dia");
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1036(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1039()
            });

            sections.Add(prefix + "6mm Dia");
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1116(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1470(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1222(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1700()
            });

            sections.Add(prefix + "9mm Dia");
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1576(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1472()
            });

            sections.Add(prefix + "12.7mm Dia");
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

            sections.Add(prefix + "18mm Dia");
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1859(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1270(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1085(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1119()
            });

            sections.Add(prefix + "25mm Dia");
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1252(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1255(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1257(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1251(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1253()
            });

            sections.Add(prefix + "25.4mm Dia");
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

            sections.Add(prefix + "30mm Dia");
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

            sections.Add(prefix + "38.1mm Dia");
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1385(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1386(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1387(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1388(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1389()
            });

            sections.Add(prefix + "50.8mm Dia");
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1401(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1145(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1050(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1384(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1417(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1399(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1979(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1301(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1256(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1725(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1380(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1727(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1779()
            });

            sections.Add(prefix + "75mm Dia");
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1740(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1238(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1002(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1353()
            });

            for (int i = 0; i < sections.Count; i++)
            {
                var linesOut = new List<string>();
                linesOut.Add(sections[i]);

                foreach (AxiLens axiLens in lenses[i])
                {
                    linesOut.Add(new MathematicaRenderableMathematicaAdapter(axiLens).RenderMathematicaFunction("Graphics"));
                }

                File.WriteAllLines(Path.Combine(saveDir, sections[i] + ".txt"), linesOut);
            }
        }

        public static void ThorlabsCatalog_BestForm()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ThorlabsCatalogBestForm");
            Directory.CreateDirectory(saveDir);

            var sections = new List<string>();
            var lenses = new List<AxiLens[]>();

            sections.Add("N-BK7 Best Form Spherical Lenses Uncoated 1in Dia");
            lenses.Add(new AxiLens[]
            {
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LBF254_040(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LBF254_050(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LBF254_075(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LBF254_100(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LBF254_150(),
                opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LBF254_200()
            });

            for (int i = 0; i < sections.Count; i++)
            {
                var linesOut = new List<string>();
                linesOut.Add(sections[i]);

                foreach (AxiLens axiLens in lenses[i])
                {
                    linesOut.Add(new MathematicaRenderableMathematicaAdapter(axiLens).RenderMathematicaFunction("Graphics"));
                }

                File.WriteAllLines(Path.Combine(saveDir, sections[i] + ".txt"), linesOut);
            }
        }
    }
}
