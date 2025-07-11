namespace opticsdotnet.Lib
{
    public class AxiOpticalAssemblyTemplate
    {
        public readonly NumItemMetricGroup NumItemMetricGroup1;

        ITemplateSpot<AxiDrift>[] AxiDriftTemplates;
        ITemplateSpot[] AxiOpticalElementTemplates;

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

            List<ITemplateSpot> templateSpots = new List<ITemplateSpot>();
            templateSpots.AddRange(AxiDriftTemplates);
            templateSpots.AddRange(AxiOpticalElementTemplates);

            NumItemMetricGroup1 = new NumItemMetricGroup(templateSpots.Select(x => x.NumItemMetricGroup1).ToArray());





























            CheckValidity(axiOpticalElementTemplates[0]);










            //foreach (ITemplateSpot<AxiDrift> axiDriftTemplate in axiDriftTemplates)
            //{

            //}















            

        }











        public AxiOpticalAssemblyTemplate(
            PossibleValueSet[] possibleValueSet,
            IOpticalMaterial[] driftOpticalMaterials,
            Type[] elementTypes
            )
        {





        }





        public static bool CheckValidity(ITemplateSpot[] tree)
        {
            throw new NotImplementedException();
            //foreach (templateSpot)




        }


        public AxiOpticalSystem Generate1()
        {
            throw new NotImplementedException();
        }
            
        static bool CheckValidity(ITemplateSpot templateSpot)
        {
            var wooo = templateSpot.ItemType;


            object woo = new();
            //







            throw new NotImplementedException();

        }
    }
}
