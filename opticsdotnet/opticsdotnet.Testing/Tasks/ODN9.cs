using opticsdotnet.Lib;

namespace opticsdotnet.Testing.ODN9
{
    public static class ODN9
    {
        public static void ODN9_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-9");
            Directory.CreateDirectory(saveDir);



            var nbk7 = new NBK7();
            var v1 = nbk7.AbsorptionCoefficient(400);
            var v2 = nbk7.AbsorptionCoefficient(-400);




        }
    }
}
