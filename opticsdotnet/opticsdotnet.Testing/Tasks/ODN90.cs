using opticsdotnet.Lib;
using opticsdotnet.Lib.Mathematica;
using System;
using System.Reflection;

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

            var v4 = new object[30];
            v4[0] = new NBK7();
            v4[1] = null;
            v4[2] = v3;
            v4[3] = 1;

            ArrayPossibleValueSet<IAxiOpticalElement> someElements = new ArrayPossibleValueSet<IAxiOpticalElement>([
                    opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1002(),
                    opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1024()
                ]);

            ArrayPossibleValueSet<IAxiOpticalElement> someElements2 = new ArrayPossibleValueSet<IAxiOpticalElement>([
                    opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1002(),
                    opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1024(),
                    opticsdotnet.Lib.Vendors.Thorlabs.Catalog.LA1027()
                ]);

            TemplateObject<SphericalSingletCurvedCurved> thirdLensTemplate = new TemplateObject<SphericalSingletCurvedCurved>(new PossibleValueSet[] {
                    new ArrayPossibleValueSet<IOpticalMaterial> ([new NBK7(), new NSF11() ]),
                    new RangePossibleValueSet(0.01, 0.015),
                    new SingleValuePossibleValueSet<double>(0.01),
                    new RangePossibleValueSet(0.01, 0.015),
                    new RangePossibleValueSet(0.01, 0.015)
            });

            RangePossibleValueSet drift1s = new RangePossibleValueSet(0.001, 0.003);
            RangePossibleValueSet drift2s = new RangePossibleValueSet(0.001, 0.003);
            RangePossibleValueSet drift3s = new RangePossibleValueSet(0.001, 0.003);

            AxiDrift possibleDrift4No1 = new AxiDrift(new Vacuum(), 0.01);
            AxiDrift possibleDrift4No2 = new AxiDrift(new Vacuum(), 0.02);

            ITemplateSpot<AxiDrift> drift4Choices = new ArrayPossibleValueSet<AxiDrift>([possibleDrift4No1, possibleDrift4No2]);

            ITemplateSpot<AxiDrift>[] axiDriftTemplates = new ITemplateSpot<AxiDrift>[]
            {
                new TemplateObject<AxiDrift>([new SingleValuePossibleValueSet<IOpticalMaterial>(new Vacuum()), drift1s]),
                new TemplateObject<AxiDrift>([new SingleValuePossibleValueSet<IOpticalMaterial>(new Vacuum()), drift2s]),
                new TemplateObject<AxiDrift>([new SingleValuePossibleValueSet<IOpticalMaterial>(new Vacuum()), drift3s]),
                drift4Choices
            };

            ITemplateSpot[] axiOpticalElementTemplates = new ITemplateSpot[]
            {
               thirdLensTemplate
            };





            AxiOpticalAssemblyTemplate axiOpticalSystemTemplate = new AxiOpticalAssemblyTemplate(
                axiDriftTemplates,
                axiOpticalElementTemplates



                );





            Type t1 = typeof(SphericalSinglet);

            //var woooo = t1.GetConstructor()




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
