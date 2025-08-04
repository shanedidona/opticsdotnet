namespace opticsdotnet.Lib
{
    public class AxiOpticalAssemblyTemplate
    {
        public readonly NumItemMetricGroup NumItemMetricGroup1;

        readonly ITemplateSpot<AxiDrift>[] AxiDriftTemplates;
        readonly ITemplateSpot[] AxiOpticalElementTemplates;
        readonly PossibleValueSet[][] JaggedPossibleValueSets;

        public AxiOpticalAssemblyTemplate(
                ITemplateSpot<AxiDrift>[] axiDriftTemplates,
                ITemplateSpot[] axiOpticalElementTemplates
            )
        {
            #region Check that each axiOpticalElementTemplate's ItemType is assignable to IAxiOpticalElement
            foreach (ITemplateSpot axiOpticalElementTemplate in axiOpticalElementTemplates)
            {
                if (!axiOpticalElementTemplate.ItemType.IsAssignableTo(typeof(IAxiOpticalElement)))
                {
                    throw new NotSupportedException("!axiOpticalElementTemplate.ItemType.IsAssignableTo(typeof(IAxiOpticalElement))");
                }
            }
            #endregion

            #region Numbers-of-Items Checking
            if (axiDriftTemplates.Length < 1)
            {
                throw new NotSupportedException("There must be at least one axiDriftTemplate");
            }

            if (axiDriftTemplates.Length != (axiOpticalElementTemplates.Length + 1))
            {
                throw new NotSupportedException("axiDriftTemplates.Length != (axiOpticalElementTemplates.Length + 1)");
            }
            #endregion

            AxiDriftTemplates = axiDriftTemplates;
            AxiOpticalElementTemplates = axiOpticalElementTemplates;

            var jaggedPossibleValueSetsList = new List<PossibleValueSet[]>();
            for (int i = 0; i < axiOpticalElementTemplates.Length; i++)
            {
                jaggedPossibleValueSetsList.Add(axiDriftTemplates[i].PossibleValueSets);
                jaggedPossibleValueSetsList.Add(axiOpticalElementTemplates[i].PossibleValueSets);
            }

            jaggedPossibleValueSetsList.Add(axiDriftTemplates.Last().PossibleValueSets);

            JaggedPossibleValueSets = jaggedPossibleValueSetsList.ToArray();

            NumItemMetricGroup1 = new NumItemMetricGroup(JaggedPossibleValueSets.Flatten2D().Select(x => x.NumItemMetricGroup1).ToArray());



















































            

        }

















        public AxiOpticalSystem Generate1()
        {
            throw new NotImplementedException();
        }
    }
}
