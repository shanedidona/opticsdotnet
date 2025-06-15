using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Lib.Vendors.Thorlabs
{
    public sealed class ThorlabsCatalogSection : IMathematicaRenderable
    {
        public string Name;
        public IAxiOpticalElement[] AxiOpticalElements;

        public ThorlabsCatalogSection(string name, IAxiOpticalElement[] axiOpticalElements)
        {
            Name = name;
            AxiOpticalElements = axiOpticalElements;
        }

        public string RenderMathematica()
        {
            var dict = new Dictionary<string, IMathematicaRenderable>();
            dict["Name"] = new StringMathematicaAdapter(Name);
            dict["AxiOpticalElements"] = new MathematicaRenderableMathematicaAdapter(AxiOpticalElements);

            return MathematicaUtil.DictionaryToMathematicaAssociation(dict);
        }
    }
}
