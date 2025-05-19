namespace opticsdotnet.Lib
{
    public static class Analysis
    {
        public static Point2D CalculateFocalPointRelToBack(
                double beamRadius,
                int numRays,
                double wavelengthNM,
                double frontDriftLength,
                double backDriftLength,
                IAxiOpticalElement axiOpticalElement
            )
        {
            var axiDenseSource = new AxiDenseSource(
                                                new double[] { 0 },
                                                Create.Linspace(-beamRadius, beamRadius, numRays),
                                                new double[] { 0 },
                                                new double[] { wavelengthNM },
                                                1.0
                                            );

            var axiDrifts = new AxiDrift[]
            {
                new AxiDrift(new Vacuum(), frontDriftLength),
                new AxiDrift(new Vacuum(), backDriftLength),
            };

            var axiElements = new IAxiOpticalElement[]
            {
                axiOpticalElement
            };

            var axiRayTerminator = new AxiFlatTerminator();

            AxiOpticalSystem axiOpticalSystem = new AxiOpticalSystem(
                    axiDenseSource, axiDrifts, axiElements, axiRayTerminator
                );

            axiOpticalSystem.RayTrace();

            Line2D[] linesOut = axiOpticalSystem.LinesOut();
            Point2D focalPoint = Geo2D.ClosestPointToLines(linesOut);

            Point2D focalPointRelToBack = new Point2D(
                    focalPoint.X - frontDriftLength - axiOpticalElement.CenterLength,
                    focalPoint.Y
                );

            return focalPointRelToBack;
        }
    }
}
