using static opticsdotnet.Lib.MathUtil;

namespace opticsdotnet.Lib
{
    public sealed partial class SphericalSinglet : IAxiOpticalElement
    {
        static void AxiRayTraceCircle(
                AxiRay axiRay,
                IOpticalMaterial opticalMaterialLeft,
                IOpticalMaterial opticalMaterialRight,
                double circleIntersectionWithAxisAbsolute,//The intersection that the circle makes with the axis for the part that we care about, in absolute coords, not relative to the axi lens
                double outerRadius,
                double circleRadius,
                bool openingRight//For left surface this means convex, for right surface this means concave
            )
        {
            if (circleRadius <= 0)
            {
                throw new NotSupportedException();
            }

            AxiRayState currentState = axiRay.GetCurrentState();

            if (!currentState.IsLive) { return; }

            //Relative to the point we care about where this circle intersects the axis
            Line2D incomingLine = new Line2D(currentState.Z0 - circleIntersectionWithAxisAbsolute, currentState.R0, currentState.Theta.Value);

            Circle2D circle2D = openingRight ? new Circle2D(circleRadius, 0, circleRadius) : new Circle2D(-circleRadius, 0, circleRadius);

            Point2D[] intersectionPoints = Geo2D.LineIntersectCircle(incomingLine, circle2D);

            if (intersectionPoints.Length == 0)
            {
                #region Line does not intersect circle
                Point2D point = Geo2D.LineIntersectLine(incomingLine, new Line2D(0, 0, Math.PI / 2));//Intersect with a fake flat surface

                axiRay.AddRange(new AxiRayState(point.X + circleIntersectionWithAxisAbsolute, point.Y, currentState.Theta, currentState.WaveLength, null));

                return;
                #endregion
            }

            if (intersectionPoints.Length == 1)
            {
                #region Line intersects circle at one point
                Point2D point = intersectionPoints[0];

                axiRay.AddRange(new AxiRayState(point.X + circleIntersectionWithAxisAbsolute, point.Y, currentState.Theta, currentState.WaveLength, null));

                return;
                #endregion
            }

            {
                #region Line intersects the circle at two points

                Point2D point = openingRight ? intersectionPoints.LeftMost() : intersectionPoints.RightMost();

                if (outerRadius <= Math.Abs(point.Y))
                {
                    //Hits circle but is outside or on the outerRadius

                    axiRay.AddRange(new AxiRayState(point.X + circleIntersectionWithAxisAbsolute, point.Y, currentState.Theta, currentState.WaveLength, null));
                    return;
                }

                //Hits circle inside outerRadius
                double driftLength = Math.Sqrt(
                                                    Sq((point.X + circleIntersectionWithAxisAbsolute) - currentState.Z0) +
                                                    Sq(point.Y - currentState.R0)
                                                );

                double? newIntensity = opticalMaterialLeft.CalculateNewIntensity(currentState.WaveLength, driftLength, currentState.Intensity.Value);

                double? newTheta = PhysicsUtil.SnellsLawThetaOut(
                                         currentState.Theta.Value,
                                         opticalMaterialLeft.IndexOfRefraction(currentState.WaveLength),
                                         opticalMaterialRight.IndexOfRefraction(currentState.WaveLength),
                                         openingRight ? Math.Asin(-point.Y / circleRadius) : Math.Asin(point.Y / circleRadius)
                                     );

                axiRay.AddRange(new AxiRayState(point.X + circleIntersectionWithAxisAbsolute, point.Y, newTheta, currentState.WaveLength, newIntensity));

                return;
                #endregion
            }
        }

        static void AxiRayTraceFlat(
                AxiRay axiRay,
                IOpticalMaterial opticalMaterialLeft,
                IOpticalMaterial opticalMaterialRight,
                double flatIntersectionWithAxisAbsolute,//The intersection that the surface makes with the axis for the part that we care about, in absolute coords, not relative to the axi lens
                double outerRadius
            )
        {
            AxiRayState currentState = axiRay.GetCurrentState();

            if (!currentState.IsLive) { return; }

            //Relative to the point we care about where this flat intersects the axis
            Line2D incomingLine = new Line2D(currentState.Z0 - flatIntersectionWithAxisAbsolute, currentState.R0, currentState.Theta.Value);

            Line2D infiniteSurface = new Line2D(0, 0, Math.PI / 2);

            Point2D intersectionPoint = Geo2D.LineIntersectLine(incomingLine, infiniteSurface);

            if (intersectionPoint == null)
            {
                axiRay.AddRange(new AxiRayState(currentState.Z0, currentState.R0, null, currentState.WaveLength, null));
                return;
            }

            if (outerRadius < Math.Abs(intersectionPoint.Y))
            {
                //Intersects surface but too far out
                axiRay.AddRange(new AxiRayState(intersectionPoint.X + flatIntersectionWithAxisAbsolute, intersectionPoint.Y, null, currentState.WaveLength, null));
                return;
            }

            {
                double driftLength = Math.Sqrt(
                                                    Sq((intersectionPoint.X + flatIntersectionWithAxisAbsolute) - currentState.Z0) +
                                                    Sq(intersectionPoint.Y - currentState.R0)
                                                );

                double? newIntensity = opticalMaterialLeft.CalculateNewIntensity(currentState.WaveLength, driftLength, currentState.Intensity.Value);

                double? newTheta = PhysicsUtil.SnellsLawThetaOut(
                                         currentState.Theta.Value,
                                         opticalMaterialLeft.IndexOfRefraction(currentState.WaveLength),
                                         opticalMaterialRight.IndexOfRefraction(currentState.WaveLength),
                                         0
                                     );

                axiRay.AddRange(new AxiRayState(intersectionPoint.X + flatIntersectionWithAxisAbsolute, intersectionPoint.Y, newTheta, currentState.WaveLength, newIntensity));
                return;
            }
        }
    }
}