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







    }
}
