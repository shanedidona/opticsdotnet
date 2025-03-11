namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public static class Catalog
    {
        //https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=112


        public static AxiLens LA1024() => new AxiLens(new NBK7(), 0.001, 0.001, 0.0021, null);
        public static AxiLens LA1026() => new AxiLens(new NBK7(), 0.001, 0.001, 0.0031, null);

        public static AxiLens LA1036() => new AxiLens(new NBK7(), 0.0015, 0.0015, 0.0031, null);
        public static AxiLens LA1039() => new AxiLens(new NBK7(), 0.0015, 0.0015, 0.0047, null);

        public static AxiLens LA1116() => new AxiLens(new NBK7(), 0.0025, 0.003, 0.0052, null);
        public static AxiLens LA1470() => new AxiLens(new NBK7(), 0.0023, 0.003, 0.0062, null);
        public static AxiLens LA1222() => new AxiLens(new NBK7(), 0.0021, 0.003, 0.0077, null);
        public static AxiLens LA1700() => new AxiLens(new NBK7(), 0.0018, 0.003, 0.0155, null);

        public static AxiLens LA1576() => new AxiLens(new NBK7(), 0.034, 0.045, 0.0062, null);
        public static AxiLens LA1472() => new AxiLens(new NBK7(), 0.025, 0.045, 0.0103, null);

        public static AxiLens LA1540() => new AxiLens(new NBK7(), 0.0051, 0.0127 / 2, 0.0077, null);
        public static AxiLens LA1074() => new AxiLens(new NBK7(), 0.0040, 0.0127 / 2, 0.0103, null);
        public static AxiLens LA1560() => new AxiLens(new NBK7(), 0.0035, 0.0127 / 2, 0.0129, null);
        public static AxiLens LA1289() => new AxiLens(new NBK7(), 0.0032, 0.0127 / 2, 0.0155, null);
        public static AxiLens LA1304() => new AxiLens(new NBK7(), 0.0028, 0.0127 / 2, 0.0206, null);
        public static AxiLens LA1213() => new AxiLens(new NBK7(), 0.0026, 0.0127 / 2, 0.0258, null);
        public static AxiLens LA1207() => new AxiLens(new NBK7(), 0.0022, 0.0127 / 2, 0.0515, null);
    }
}
