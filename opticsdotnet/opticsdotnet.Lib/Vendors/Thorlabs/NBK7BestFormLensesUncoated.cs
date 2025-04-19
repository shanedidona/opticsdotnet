namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public static partial class Catalog
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=900


        public static AxiLens LBF254_040() => new AxiLens(new NBK7(), 0.0065, 0.0254 / 2, 0.02402, 0.13460);
        public static AxiLens LBF254_050() => new AxiLens(new NBK7(), 0.0065, 0.0254 / 2, 0.03006, 0.17200);
        public static AxiLens LBF254_075() => new AxiLens(new NBK7(), 0.0050, 0.0254 / 2, 0.04450, 0.28900);
        public static AxiLens LBF254_100() => new AxiLens(new NBK7(), 0.0040, 0.0254 / 2, 0.06002, 0.35330);
        public static AxiLens LBF254_150() => new AxiLens(new NBK7(), 0.0040, 0.0254 / 2, 0.08935, 0.57049);
        public static AxiLens LBF254_200() => new AxiLens(new NBK7(), 0.0040, 0.0254 / 2, 0.12150, 0.68450);
    }
}
