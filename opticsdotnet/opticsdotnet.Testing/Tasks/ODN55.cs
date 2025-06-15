using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Testing.ODN55
{
    public static class ODN55
    {
        public static void ODN55_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-55");
            Directory.CreateDirectory(saveDir);

            string[] stringsIn = new string[]
            {
                "test1",
                "\ntest1",
                "\\",
                ""

            };

            string[] stringsOut = stringsIn.Select(x => (new StringMathematicaAdapter(x)).RenderMathematica()).ToArray();

            File.WriteAllLines(Path.Combine(saveDir, "stringsIn.txt"), stringsIn);
            File.WriteAllLines(Path.Combine(saveDir, "stringsOut.txt"), stringsOut);
        }
    }
}
