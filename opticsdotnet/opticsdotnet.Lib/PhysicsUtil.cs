using static opticsdotnet.Lib.MathUtil;
using ScottPlot;

namespace opticsdotnet.Lib
{
    public static class PhysicsUtil
    {
        static readonly LinearSplineWithMinMax[] WaveLengthToRGB1Data = IOUtil.LinearSplinesWithMinMaxFromCSVFile("Data//WaveLengthToRGB1//WaveLengthToRGB1.csv");


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

        public static double? SnellsLawThetaOut(
                double thetaIn,//Relative to +X axis
                double? nLeft,
                double? nRight,
                double normalThetaIntoRight//Relative to +X axis
            )
        {
            if (!nLeft.HasValue)
            {
                return null;
            }

            if (!nRight.HasValue)
            {
                return null;
            }

            if (PiOver2 <= Math.Abs(thetaIn))
            {
                throw new NotSupportedException("(0.5 * Math.PI) <= Math.Abs(thetaIn)");
            }

            if (PiOver2 <= Math.Abs(normalThetaIntoRight))
            {
                throw new NotSupportedException("(0.5 * Math.PI) <= Math.Abs(normalThetaIntoRight)");
            }

            if (nRight < nLeft)
            {
                //Total Internal Reflection Check

                double criticalAngle = Math.Asin(nRight.Value / nLeft.Value);

                if (criticalAngle <= Math.Abs(thetaIn))
                {
                    return null;
                }
            }

            double absRelThetaOut = Math.Asin(Math.Sin(Math.Abs(thetaIn - normalThetaIntoRight)) * nLeft.Value / nRight.Value);//Order does not matter since abs

            double thetaOut = normalThetaIntoRight + Math.Sign(thetaIn - normalThetaIntoRight) * absRelThetaOut;

            return thetaOut;
        }

        public static double? CalculateNewIntensity(
                this IOpticalMaterial opticalMaterial,
                double waveLength,
                double driftLength,
                double oldIntensity
            )
        {
            double? absorptionCoefficient = opticalMaterial.AbsorptionCoefficient(waveLength);

            if (absorptionCoefficient.HasValue)
            {
                return oldIntensity * Math.Exp(-driftLength * absorptionCoefficient.Value);
            }
            else
            {
                return null;
            }
        }

        public static (double R1, double G1, double B1) WaveLengthToRGB1(double waveLength)
        {
            if (waveLength < WaveLengthToRGB1Data[0].MinIndep)
            {
                return (0, 0, 0);
            }

            if (WaveLengthToRGB1Data[0].MaxIndep < waveLength)
            {
                return (0, 0, 0);
            }

            return (
                        WaveLengthToRGB1Data[0].LinearSpline1.Interpolate(waveLength),
                        WaveLengthToRGB1Data[1].LinearSpline1.Interpolate(waveLength),
                        WaveLengthToRGB1Data[2].LinearSpline1.Interpolate(waveLength)
                );
        }
    }
}
