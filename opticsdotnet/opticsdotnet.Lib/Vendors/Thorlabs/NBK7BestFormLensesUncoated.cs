namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public static partial class Catalog
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=900


        public static SphericalSinglet LBF254_040() => new SphericalSinglet(new NBK7(), 0.0065, 0.0254 / 2, 0.02402, 0.13460);
        public static SphericalSinglet LBF254_050() => new SphericalSinglet(new NBK7(), 0.0065, 0.0254 / 2, 0.03006, 0.17200);
        public static SphericalSinglet LBF254_075() => new SphericalSinglet(new NBK7(), 0.0050, 0.0254 / 2, 0.04450, 0.28900);
        public static SphericalSinglet LBF254_100() => new SphericalSinglet(new NBK7(), 0.0040, 0.0254 / 2, 0.06002, 0.35330);
        public static SphericalSinglet LBF254_150() => new SphericalSinglet(new NBK7(), 0.0040, 0.0254 / 2, 0.08935, 0.57049);
        public static SphericalSinglet LBF254_200() => new SphericalSinglet(new NBK7(), 0.0040, 0.0254 / 2, 0.12150, 0.68450);

        public static ThorlabsCatalogPage NBK7BestFormLensesUncoated()
        {
            ThorlabsCatalogSection thorlabsCatalogSection = new ThorlabsCatalogSection(
                "Ø1\" N-BK7 Best Form Spherical Lenses, Uncoated",
                [
                    LBF254_040(),
                    LBF254_050(),
                    LBF254_075(),
                    LBF254_100(),
                    LBF254_150(),
                    LBF254_200()
                    ]
                );

            return new ThorlabsCatalogPage(
                "Ø1\" N-BK7 Best Form Spherical Lenses, Uncoated",
                [thorlabsCatalogSection],
                "https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=900"
                );
        }
    }
}
