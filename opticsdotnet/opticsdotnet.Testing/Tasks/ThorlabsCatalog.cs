using opticsdotnet.Lib;
using opticsdotnet.Lib.Vendors.Thorlabs;
using static opticsdotnet.Lib.Vendors.Thorlabs.Catalog;

namespace opticsdotnet.Testing.ThorlabsCatalog
{
    public static class ThorlabsCatalog
    {
        public static void ThorlabsCatalog_Run()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ThorlabsCatalog", "Renderings");
            Directory.CreateDirectory(saveDir);

            var pages = new ThorlabsCatalogPage[]
            {
                NBK7BestFormLensesUncoated(),
                NBK7PlanoConvexLensesUncoated(),
                NBK7PlanoConcaveLensesUncoated(),
                NBK7PositiveMeniscusLenses()
            };

            string s1 = (new MathematicaRenderableMathematicaAdapter(pages)).RenderMathematica();

            File.WriteAllText(Path.Combine(saveDir, "Renderings.txt"), s1);
        }
    }
}
