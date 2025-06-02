using opticsdotnet.Lib;

namespace opticsdotnet.Testing.OpticalMaterials
{
    public static class OpticalMaterials
    {
        public static void OpticalMaterials_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "OpticalMaterials");
            Directory.CreateDirectory(saveDir);

            PhysicsUtil.OpticalMaterialPlot(new NBK7(), Path.Combine(saveDir, "ODN9_1.png"), 1000);
        }
    }
}
