using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public sealed class ThorlabsCatalogPage : IMathematicaRenderable
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

        public string RenderMathematica()
        {
            var dict = new Dictionary<string, IMathematicaRenderable>();
            dict["Name"] = new StringMathematicaAdapter(Name);
            dict["ThorlabsCatalogSections"] = new MathematicaRenderableMathematicaAdapter(ThorlabsCatalogSections);
            dict["URL"] = new StringMathematicaAdapter(URL);

            return MathematicaUtil.DictionaryToMathematicaAssociation(dict);
        }
    }
}
