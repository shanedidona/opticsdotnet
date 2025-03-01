using opticsdotnet.Lib;

namespace opticsdotnet.Testing
{
    internal class Program
    {
        public static string BaseSaveDir;

        static void Main(string[] args)
        {
            BaseSaveDir = File.ReadAllLines("settings.txt")[0];

            ODN1.ODN1.ODN1_1();

            var nbk7 = new NBK7();
            var v1 = nbk7.AbsorptionCoefficient(400);
            var v2 = nbk7.AbsorptionCoefficient(-400);
        }
    }
}
