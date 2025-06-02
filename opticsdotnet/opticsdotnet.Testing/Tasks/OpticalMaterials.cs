using opticsdotnet.Lib;

namespace opticsdotnet.Testing.OpticalMaterials
{
    public static class OpticalMaterials
    {
        public static void OpticalMaterials_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-9");
            Directory.CreateDirectory(saveDir);



            var nbk7 = new NBK7();
            var v1 = nbk7.AbsorptionCoefficient(400);
            var v2 = nbk7.AbsorptionCoefficient(-400);

            PhysicsUtil.OpticalMaterialPlot(nbk7, Path.Combine(saveDir, "ODN9_1.png"), 1000);


        }
    }
}
