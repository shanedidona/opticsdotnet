namespace opticsdotnet.Lib
{
    public class AxiOpticalAssemblyTemplate
    {
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








            AxiDriftTemplates = axiDriftTemplates;
            AxiOpticalElementTemplates = axiOpticalElementTemplates;





























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
