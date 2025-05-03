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
                LA1024(),
                LA1026()
            ]);

            sections.Add(prefix + "3mm Dia");
            lenses.Add([
                LA1036(),
                LA1039()
            ]);

            sections.Add(prefix + "6mm Dia");
            lenses.Add([
                LA1116(),
                LA1470(),
                LA1222(),
                LA1700()
            ]);

            sections.Add(prefix + "9mm Dia");
            lenses.Add([
                LA1576(),
                LA1472()
            ]);

            sections.Add(prefix + "12.7mm Dia");
            lenses.Add([
                LA1540(),
                LA1074(),
                LA1560(),
                LA1289(),
                LA1304(),
                LA1213(),
                LA1207()
            ]);

            sections.Add(prefix + "18mm Dia");
            lenses.Add([
                LA1859(),
                LA1270(),
                LA1085(),
                LA1119()
            ]);

            sections.Add(prefix + "25mm Dia");
            lenses.Add([
                LA1252(),
                LA1255(),
                LA1257(),
                LA1251(),
                LA1253()
            ]);

            sections.Add(prefix + "25.4mm Dia");
            lenses.Add([
                LA1951(),
                LA1805(),
                LA1027(),
                LA1422(),
                LA1131(),
                LA1134(),
                LA1608(),
                LA1509(),
                LA1986(),
                LA1433(),
                LA1229(),
                LA1708(),
                LA1461(),
                LA1484(),
                LA1172(),
                LA1908(),
                LA1978(),
                LA1464(),
                LA1254(),
                LA1258(),
                LA1259()
            ]);

            sections.Add(prefix + "30mm Dia");
            lenses.Add([
                LA1274(),
                LA1102(),
                LA1765(),
                LA1031(),
                LA1907(),
                LA1541(),
                LA1832(),
                LA1419(),
                LA1237()
            ]);

            sections.Add(prefix + "38.1mm Dia");
            lenses.Add([
                LA1385(),
                LA1386(),
                LA1387(),
                LA1388(),
                LA1389()
            ]);

            sections.Add(prefix + "50.8mm Dia");
            lenses.Add([
                LA1401(),
                LA1145(),
                LA1050(),
                LA1384(),
                LA1417(),
                LA1399(),
                LA1979(),
                LA1301(),
                LA1256(),
                LA1725(),
                LA1380(),
                LA1727(),
                LA1779()
            ]);

            sections.Add(prefix + "75mm Dia");
            lenses.Add([
                LA1740(),
                LA1238(),
                LA1002(),
                LA1353()
            ]);

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
                LBF254_040(),
                LBF254_050(),
                LBF254_075(),
                LBF254_100(),
                LBF254_150(),
                LBF254_200()
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
