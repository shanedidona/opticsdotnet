namespace opticsdotnet.Lib
{
    public class AxiOpticalSystemTemplate
    {
        public AxiOpticalSystemTemplate(
                ITemplateSpot<AxiDrift>[] axiDriftTemplates,
                TemplateObject<IAxiOpticalElement>[] axiOpticalElementTemplates
            )
        {

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
