namespace opticsdotnet.Lib.Objects
{
    public sealed class ThorlabsCatalogSection
    {
        public string Name;
        public IAxiOpticalElement[] AxiOpticalElements;

        public ThorlabsCatalogSection(string name, IAxiOpticalElement[] axiOpticalElements)
        {
            Name = name;
            AxiOpticalElements = axiOpticalElements;
        }
    }
}
