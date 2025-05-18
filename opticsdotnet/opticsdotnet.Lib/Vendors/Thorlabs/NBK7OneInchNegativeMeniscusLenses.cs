namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public static partial class Catalog
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=902
        //Note that this is just the uncoated lenses on the page


        public static AxiLens LF1822() => new AxiLens(new NBK7(), 0.003, 0.0254 / 2, 0.100, -0.0337);
        public static AxiLens LF1547() => new AxiLens(new NBK7(), 0.003, 0.0254 / 2, 0.100, -0.0431);
        public static AxiLens LF1097() => new AxiLens(new NBK7(), 0.003, 0.0254 / 2, 0.100, -0.0502);
        public static AxiLens LF1015() => new AxiLens(new NBK7(), 0.003, 0.0254 / 2, 0.250, -0.0951);
        public static AxiLens LF1544() => new AxiLens(new NBK7(), 0.003, 0.0254 / 2, 0.250, -0.1125);
        public static AxiLens LF1988() => new AxiLens(new NBK7(), 0.003, 0.0254 / 2, 0.250, -0.1263);
        public static AxiLens LF1141() => new AxiLens(new NBK7(), 0.003, 0.0254 / 2, 0.500, -0.2532);


        public static ThorlabsCatalogPage NBK7OneInchNegativeMeniscusLenses()
        {
            var sections = new List<ThorlabsCatalogSection>();

            sections.Add(new ThorlabsCatalogSection(
                    "Ø1\" N-BK7 Negative Meniscus Lenses, Uncoated",
                    [LF1822(), LF1547(), LF1097(), LF1015(), LF1544(), LF1988(), LF1141()]
                ));

            return new ThorlabsCatalogPage(
                    "Ø1\" N-BK7 Negative Meniscus Lenses",
                    sections.ToArray(),
                    "https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=902"
                );
        }
    }
}