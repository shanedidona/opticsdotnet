using opticsdotnet.Lib;

namespace opticsdotnet.Testing
{
    internal class Program
    {
        public static string BaseSaveDir;

        static void Main(string[] args)
        {
            BaseSaveDir = File.ReadAllLines("settings.txt")[0];

            opticsdotnet.Testing.ThorlabsCatalog.ThorlabsCatalog.ThorlabsCatalog_Run();

            opticsdotnet.Testing.ODN36.ODN36.ODN36_3();

            opticsdotnet.Testing.ODN36.ODN36.ODN36_1();

            opticsdotnet.Testing.WaveLengthToRGB1.WaveLengthToRGB1.WaveLengthToRGB1_1();
        }
    }
}
