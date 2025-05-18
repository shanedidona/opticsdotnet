namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public static partial class Catalog
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=130
        //Note that this is just the uncoated lenses on the page


        public static AxiLens LE1234() => new AxiLens(new NBK7(), 0.0036, 0.0254 / 2, 0.0321, -0.0822);
        public static AxiLens LE1156() => new AxiLens(new NBK7(), 0.0033, 0.0254 / 2, 0.0406, -0.1069);
        public static AxiLens LE1104() => new AxiLens(new NBK7(), 0.0031, 0.0254 / 2, 0.0491, -0.1316);
        public static AxiLens LE1202() => new AxiLens(new NBK7(), 0.0028, 0.0254 / 2, 0.0662, -0.1822);
        public static AxiLens LE1929() => new AxiLens(new NBK7(), 0.0025, 0.0254 / 2, 0.1009, -0.2882);

        public static AxiLens LE1076() => new AxiLens(new NBK7(), 0.0097, 0.0254, 0.0303, -0.0658);
        public static AxiLens LE1418() => new AxiLens(new NBK7(), 0.0073, 0.0254, 0.0479, -0.1193);
        public static AxiLens LE1015() => new AxiLens(new NBK7(), 0.0062, 0.0254, 0.0652, -0.1716);
        public static AxiLens LE1613() => new AxiLens(new NBK7(), 0.0055, 0.0254, 0.0825, -0.2247);
        public static AxiLens LE1985() => new AxiLens(new NBK7(), 0.0051, 0.0254, 0.1001, -0.2791);

        public static ThorlabsCatalogPage NBK7PositiveMeniscusLenses()
        {
            var sections = new List<ThorlabsCatalogSection>();

            sections.Add(new ThorlabsCatalogSection(
                    "Ø1\" N-BK7 Positive Meniscus Lenses",
                    [LE1234(), LE1156(), LE1104(), LE1202(), LE1929()]
                ));

            sections.Add(new ThorlabsCatalogSection(
                    "Ø2\" N-BK7 Positive Meniscus Lenses",
                    [LE1076(), LE1418(), LE1015(), LE1613(), LE1985()]
                ));

            return new ThorlabsCatalogPage(
                    "N-BK7 Positive Meniscus Lenses",
                    sections.ToArray(),
                    "https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=130"
                );
        }
    }
}