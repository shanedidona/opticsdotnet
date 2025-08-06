namespace opticsdotnet.Lib
{
    public class AxiOpticalAssemblyTemplate
    {
        public readonly NumItemMetricGroup NumItemMetricGroup1;

        readonly ITemplateSpot<AxiDrift>[] AxiDriftTemplates;
        readonly ITemplateSpot[] AxiOpticalElementTemplates;
        readonly PossibleValueSet[][] JaggedPossibleValueSets;

        readonly Dictionary<(int, int), RangePossibleValueSet> RangePossibleValueSets = new();
        readonly Dictionary<(int, int), PossibleValueSet> SinglePossibleValueSets = new();
        readonly Dictionary<(int, int), PossibleValueSet> ArrayPossibleValueSets = new();

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

            for (int itemI = 0; itemI < JaggedPossibleValueSets.Length; itemI++)
            {
                for (int possibleValueSetI = 0; possibleValueSetI < JaggedPossibleValueSets[itemI].Length; possibleValueSetI++)
                {
                    PossibleValueSet possibleValueSet = JaggedPossibleValueSets[itemI][possibleValueSetI];

                    if (!possibleValueSet.NumItemMetricGroup1.NumItemsIncludingContinuous.HasValue)
                    {
                        RangePossibleValueSets.Add((itemI, possibleValueSetI), (RangePossibleValueSet)possibleValueSet);
                        continue;
                    }

                    if (possibleValueSet.NumItemMetricGroup1.NumItemsIncludingContinuous.Value == 1)
                    {
                        SinglePossibleValueSets.Add((itemI, possibleValueSetI), possibleValueSet);
                        continue;
                    }

                    ArrayPossibleValueSets.Add((itemI, possibleValueSetI), possibleValueSet);
                }
            }


















            foreach (PossibleValueSet[] possibleValueSetsForItem in jaggedPossibleValueSetsList)
            {
                foreach (PossibleValueSet possibleValueSet in possibleValueSetsForItem)
                {
                    if (!possibleValueSet.NumItemMetricGroup1.NumItemsIncludingContinuous.HasValue)
                    {
                        RangePossibleValueSets

                        continue;
                    }



                    if (possibleValueSet.NumItemMetricGroup1.NumItemsIncludingContinuous == 1)
                    {

                    }

                    if (possibleValueSet.NumItemMetricGroup1.NumItemsIncludingContinuous == 1)
                    {

                    }





                    //1 case

                    //null case

                    //other than 1 case




                }
            }

















































            

        }

















        public AxiOpticalSystem Generate1(int[] choiceIndices, double[] continuousValues)
        {
            throw new NotImplementedException();
        }
    }
}
