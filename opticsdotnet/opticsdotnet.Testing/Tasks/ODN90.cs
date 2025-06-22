using opticsdotnet.Lib;
using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Testing.ODN90
{
    public static class ODN90
    {
        public static void ODN90_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "ODN-90");
            Directory.CreateDirectory(saveDir);


            var v1 = new RangePossibleValueSet(1, 2);
            var v2 = new SingleValuePossibleValueSet<Circle2D>(new Circle2D(1, 2, 3));

            Type v3 = typeof(RangePossibleValueSet);
            bool b1 = v3.Equals(v3);


            PossibleValueSet_Extensions.NumberOfPermutations([v1, v2]);






            return;







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
