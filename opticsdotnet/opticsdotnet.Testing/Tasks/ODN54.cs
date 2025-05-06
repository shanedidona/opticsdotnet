using opticsdotnet.Lib;

namespace opticsdotnet.Testing.ODN54
{
    public static class ODN54
    {
        public static void ODN54_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-54");
            Directory.CreateDirectory(saveDir);

            var dict = new Dictionary<string, Geo2D>();
            string string1 = MathematicaUtil.DictionaryToMathematicaAssociation(dict);

            dict.Add("Circle1", new Circle2D(0, 2, 1.3));
            string string2 = MathematicaUtil.DictionaryToMathematicaAssociation(dict);

            dict.Add("Circle2", new Circle2D(0, 4, 1.3));
            string string3 = MathematicaUtil.DictionaryToMathematicaAssociation(dict);

            dict.Add("C\nircle2", new Circle2D(0, 4, 1.3));
            string string4 = MathematicaUtil.DictionaryToMathematicaAssociation(dict);

            File.WriteAllLines(Path.Combine(saveDir, "ODN-54.txt"), [string1, string2, string3, string4]);
        }
    }
}
