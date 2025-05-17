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






    }
}