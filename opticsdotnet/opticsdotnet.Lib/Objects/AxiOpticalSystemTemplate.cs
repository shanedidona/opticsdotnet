namespace opticsdotnet.Lib
{
    public class AxiOpticalSystemTemplate
    {
        public AxiOpticalSystemTemplate(
                ITemplateSpot<AxiDrift>[] axiDriftTemplates,
                ITemplateSpot[] axiOpticalElementTemplates
            )
        {
            foreach (ITemplateSpot axiOpticalElementTemplate in axiOpticalElementTemplates)
            {
                if (!axiOpticalElementTemplate.ItemType.IsAssignableTo(typeof(IAxiOpticalElement)))
                {
                    throw new NotSupportedException("!axiOpticalElementTemplate.ItemType.IsAssignableTo(typeof(IAxiOpticalElement))");
                }
            }

        }











        public AxiOpticalSystemTemplate(
            PossibleValueSet[] possibleValueSet,
            IOpticalMaterial[] driftOpticalMaterials,
            Type[] elementTypes
            )
        {





        }





        public static bool CheckValidity(ITemplateSpot[] tree)
        {

            throw new NotImplementedException();




        }


        public AxiOpticalSystem Generate1()
        {
            throw new NotImplementedException();
        }
            




    }
}
