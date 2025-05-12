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
    }
}
