using opticsdotnet.Lib;

namespace opticsdotnet.Testing.OpticalMaterials
{
    public static class OpticalMaterials
    {
        public static void OpticalMaterials_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "OpticalMaterials");
            Directory.CreateDirectory(saveDir);

            PhysicsUtil.OpticalMaterialPlot(new NBK7(), Path.Combine(saveDir, "NBK7.png"), 1000);
            PhysicsUtil.OpticalMaterialPlot(new NSF11(), Path.Combine(saveDir, "NSF11.png"), 1000);
        }
    }
}
