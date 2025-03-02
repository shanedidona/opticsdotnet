using ScottPlot;

namespace opticsdotnet.Lib
{
    public static class PhysicsUtil
    {
        public static double SellmeierEvaluate(
                double wavelength,//nanometers
                double b1,
                double b2,
                double b3,
                double c1,
                double c2,
                double c3
            )
        {
            double lambdaSquared = 0.001 * wavelength;
            lambdaSquared = lambdaSquared * lambdaSquared;

            double nSquared = 1;
            nSquared += b1 * lambdaSquared / (lambdaSquared - c1);
            nSquared += b2 * lambdaSquared / (lambdaSquared - c2);
            nSquared += b3 * lambdaSquared / (lambdaSquared - c3);

            return Math.Sqrt(nSquared);
        }

        public static void OpticalMaterialPlot(IOpticalMaterial opticalMaterial, string pathOut, int pointsPerPlot)
        {
            Multiplot multiplot = new Multiplot();
            multiplot.AddPlots(2);

            double minWavelength = 0.9 * Math.Min(opticalMaterial.IndexOfRefractionMinWavelength.Value, opticalMaterial.AbsorptionCoefficientMinWavelength.Value);
            double maxWavelength = 1.1 * Math.Max(opticalMaterial.IndexOfRefractionMaxWavelength.Value, opticalMaterial.AbsorptionCoefficientMaxWavelength.Value);

            {
                double[] wavelengths = Create.Linspace(opticalMaterial.IndexOfRefractionMinWavelength.Value, opticalMaterial.IndexOfRefractionMaxWavelength.Value, pointsPerPlot);
                double[] indicesOfRefraction = wavelengths.Select(opticalMaterial.IndexOfRefraction).Select(x => x.Value).ToArray();

                Plot indexOfRefractionPlot = multiplot.GetPlot(0);
                indexOfRefractionPlot.Add.Scatter(wavelengths, indicesOfRefraction);
                indexOfRefractionPlot.XLabel("λ (nm)");
                indexOfRefractionPlot.YLabel("Index Of Refraction");
                indexOfRefractionPlot.Axes.SetLimitsX(minWavelength, maxWavelength);
            }

            {
                double[] wavelengths = Create.Linspace(opticalMaterial.AbsorptionCoefficientMinWavelength.Value, opticalMaterial.AbsorptionCoefficientMaxWavelength.Value, pointsPerPlot);
                double[] absorptionCoefficients = wavelengths.Select(opticalMaterial.AbsorptionCoefficient).Select(x => x.Value).ToArray();

                Plot absorptionCoefficientPlot = multiplot.GetPlot(1);
                absorptionCoefficientPlot.Add.Scatter(wavelengths, absorptionCoefficients);
                absorptionCoefficientPlot.XLabel("λ (nm)");
                absorptionCoefficientPlot.YLabel("Absorption Coefficient (1/m)");
                absorptionCoefficientPlot.Axes.SetLimitsX(minWavelength, maxWavelength);
            }

            multiplot.SavePng(pathOut, 1000, 1000);
        }
    }
}
