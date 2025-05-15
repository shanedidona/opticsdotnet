namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public static partial class Catalog
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=2087


        public static AxiLens LC1975() => new AxiLens(new NBK7(), 0.002, 0.003, -0.0124, null);

        public static AxiLens LC1906() => new AxiLens(new NBK7(), 0.002, 0.0045, -0.0139, null);

        public static AxiLens LC1054() => new AxiLens(new NBK7(), 0.003, 0.0127 / 2, -0.0129, null);
        public static AxiLens LC1060() => new AxiLens(new NBK7(), 0.003, 0.0127 / 2, -0.0154, null);
        public static AxiLens LC1439() => new AxiLens(new NBK7(), 0.0035, 0.0127 / 2, -0.0257, null);

        public static AxiLens LC1259() => new AxiLens(new NBK7(), 0.0035, 0.0125, -0.0257, null);
        public static AxiLens LC1258() => new AxiLens(new NBK7(), 0.0035, 0.0125, -0.0386, null);
        public static AxiLens LC1254() => new AxiLens(new NBK7(), 0.004, 0.0125, -0.0515, null);

        public static AxiLens LC1715() => new AxiLens(new NBK7(), 0.0035, 0.0254 / 2, -0.0257, null);
        public static AxiLens LC1582() => new AxiLens(new NBK7(), 0.0035, 0.0254 / 2, -0.0386, null);
        public static AxiLens LC1120() => new AxiLens(new NBK7(), 0.004, 0.0254 / 2, -0.0515, null);

        public static AxiLens LC1315() => new AxiLens(new NBK7(), 0.0035, 0.0508 / 2, -0.0386, null);
        public static AxiLens LC1093() => new AxiLens(new NBK7(), 0.004, 0.0508 / 2, -0.0515, null);
        public static AxiLens LC1611() => new AxiLens(new NBK7(), 0.004, 0.0508 / 2, -0.0772, null);

        public static ThorlabsCatalogPage NBK7PlanoConcaveLensesUncoated()
        {
            var sections = new List<ThorlabsCatalogSection>();

            sections.Add(new ThorlabsCatalogSection(
                    "Ø6.0 mm N-BK7 Plano-Concave Lens",
                    [LC1975()]
                ));

            sections.Add(new ThorlabsCatalogSection(
                    "Ø9.0 mm N-BK7 Plano-Concave Lens",
                    [LC1906()]
                ));

            sections.Add(new ThorlabsCatalogSection(
                    "Ø1/2\" (12.7 mm) N-BK7 Plano-Concave Lenses",
                    [LC1054(), LC1060(), LC1439()]
                ));

            sections.Add(new ThorlabsCatalogSection(
                    "Ø25 mm N-BK7 Plano-Concave Lenses",
                    [LC1259(), LC1258(), LC1254()]
                ));

            sections.Add(new ThorlabsCatalogSection(
                    "Ø1\" (25.4 mm) N-BK7 Plano-Concave Lenses",
                    [LC1715(), LC1582(), LC1120()]
                ));

            sections.Add(new ThorlabsCatalogSection(
                    "Ø2\" (50.8 mm) N-BK7 Plano-Concave Lenses",
                    [LC1315(), LC1093(), LC1611()]
                ));

            return new ThorlabsCatalogPage(
                    "N-BK7 Plano-Concave Lenses, Uncoated",
                    sections.ToArray(),
                    "https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=2087"
                );
        }
    }
}
