namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public static partial class Catalog
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=256


        public static SphericalSinglet LD2746() => new SphericalSinglet(new NSF11(), 0.0015, 0.003, -0.0097, -0.0097);

        public static SphericalSinglet LD2568() => new SphericalSinglet(new NSF11(), 0.002, 0.0045, -0.0144, -0.0144);

        public static SphericalSinglet LD2060() => new SphericalSinglet(new NSF11(), 0.003, 0.0254 / 4, -0.024, -0.024);
        public static SphericalSinglet LD1357() => new SphericalSinglet(new NBK7(), 0.0035, 0.0254 / 4, -0.0521, -0.0521);

        public static SphericalSinglet LD2297() => new SphericalSinglet(new NSF11(), 0.003, 0.0254 / 2, -0.0396, -0.0396);
        public static SphericalSinglet LD1464() => new SphericalSinglet(new NBK7(), 0.003, 0.0254 / 2, -0.052, -0.052);
        public static SphericalSinglet LD1170() => new SphericalSinglet(new NBK7(), 0.0035, 0.0254 / 2, -0.0779, -0.0779);
        public static SphericalSinglet LD1613() => new SphericalSinglet(new NBK7(), 0.004, 0.0254 / 2, -0.1037, -0.1037);


        public static ThorlabsCatalogPage NBK7andNSF11BiConcaveLensesUncoated()
        {
            var sections = new List<ThorlabsCatalogSection>();

            sections.Add(new ThorlabsCatalogSection(
                    "Ø6 mm Bi-Concave Lenses",
                    [LD2746()]
                ));

            sections.Add(new ThorlabsCatalogSection(
                    "Ø9 mm Bi-Concave Lenses",
                    [LD2568()]
                ));

            sections.Add(new ThorlabsCatalogSection(
                    "Ø1/2\" (Ø12.7 mm) Bi-Concave Lenses",
                    [LD2060(), LD1357()]
                ));

            sections.Add(new ThorlabsCatalogSection(
                    "Ø1\" (Ø25.4 mm) Bi-Concave Lenses",
                    [LD2297(), LD1464(), LD1170(), LD1613()]
                ));

            return new ThorlabsCatalogPage(
                    "N-BK7 and N-SF11 Bi-Concave Lenses, Uncoated",
                    sections.ToArray(),
                    "https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=256"
                );
        }
    }
}
