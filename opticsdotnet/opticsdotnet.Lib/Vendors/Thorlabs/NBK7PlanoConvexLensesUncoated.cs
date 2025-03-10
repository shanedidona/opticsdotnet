namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public static class Catalog
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=112


        public static AxiLens LA1024() => new AxiLens(new NBK7(), 0.001, 0.001, 0.0021, null);
        public static AxiLens LA1026() => new AxiLens(new NBK7(), 0.001, 0.001, 0.0031, null);
    }
}
