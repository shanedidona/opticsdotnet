using opticsdotnet.Lib;

namespace opticsdotnet.Testing
{
    internal class Program
    {
        public static string BaseSaveDir;

        static void Main(string[] args)
        {
            BaseSaveDir = File.ReadAllLines("settings.txt")[0];

            ThorlabsCatalog.ThorlabsCatalog.ThorlabsCatalog_1();
        }
    }
}
