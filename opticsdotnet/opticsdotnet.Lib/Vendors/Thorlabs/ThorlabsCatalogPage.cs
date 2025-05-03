namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public sealed class ThorlabsCatalogPage
    {
        public string Name;
        public ThorlabsCatalogSection[] ThorlabsCatalogSections;
        public string URL;


        public ThorlabsCatalogPage(string name, ThorlabsCatalogSection[] thorlabsCatalogSections, string url)
        {
            Name = name;
            ThorlabsCatalogSections = thorlabsCatalogSections;
            URL = url;
        }
    }
}
