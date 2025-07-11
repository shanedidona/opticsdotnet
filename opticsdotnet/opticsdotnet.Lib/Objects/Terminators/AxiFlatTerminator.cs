﻿using static opticsdotnet.Lib.MathUtil;

namespace opticsdotnet.Lib
{
    public sealed class AxiFlatTerminator : IAxiRayTerminator
    {
        readonly Line2D Flat = new Line2D(0, 0, PiOver2);


        public IEnumerable<AxiRay> AxiRayTrace(double thisZ0, AxiDrift previousDrift, IEnumerable<AxiRay> axiRays)
        {
            foreach (AxiRay axiRay in axiRays)
            {
                AxiRayState currentState = axiRay.GetCurrentState();

                if (!currentState.IsLive) { continue; }

                //Relative to the point we care about where this flat intersects the axis
                Line2D incomingLine = new Line2D(currentState.Z0 - thisZ0, currentState.R0, currentState.Theta.Value);

                Point2D intersectionPoint = Geo2D.LineIntersectLine(incomingLine, Flat);

                double driftLength = Math.Sqrt(
                                                    Sq((intersectionPoint.X + thisZ0) - currentState.Z0) +
                                                    Sq(intersectionPoint.Y - currentState.R0)
                                                );

                double? newIntensity = previousDrift.OpticalMaterial.CalculateNewIntensity(currentState.WaveLength, driftLength, currentState.Intensity.Value);

                axiRay.AddRange(new AxiRayState(intersectionPoint.X + thisZ0, intersectionPoint.Y, currentState.Theta, currentState.WaveLength, newIntensity));

                yield return axiRay;
            }
        }

        public string RenderMathematica()
        {
            return Flat.RenderMathematica();
        }
    }
}
