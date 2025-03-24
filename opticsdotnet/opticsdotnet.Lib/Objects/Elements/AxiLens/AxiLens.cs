﻿using static opticsdotnet.Lib.MathUtil;

namespace opticsdotnet.Lib
{
    public sealed partial class AxiLens : IAxiOpticalElement
    {
        public AxiLens(IOpticalMaterial opticalMaterial, double centerThickness, double outerRadius, double? radius1, double? radius2)
        {
            CenterThickness = centerThickness;
            OuterRadius = outerRadius;
            Radius1 = radius1;
            Radius2 = radius2;
            OpticalMaterial = opticalMaterial;
        }

        public void AxiRayTrace(double thisZ0, AxiDrift previousDrift, AxiDrift nextDrift, AxiRay[] axiRays)//TODO: support total internal reflection
        {
            //Rays Hitting Left Surface or nothing
            foreach (AxiRay axiRay in axiRays)
            {
                if (Radius1.HasValue)
                {
                    AxiRayTraceCircle(
                            axiRay,
                            previousDrift.OpticalMaterial,
                            OpticalMaterial,
                            thisZ0,
                            OuterRadius,
                            Math.Abs(Radius1.Value),
                            0 < Radius1.Value
                        );
                }
                else
                {
                    AxiRayTraceFlat(
                            axiRay,
                            previousDrift.OpticalMaterial,
                            OpticalMaterial,
                            thisZ0,
                            OuterRadius
                        );
                }
            }

            //Rays Hitting Right Surface or Nothing
            foreach (AxiRay axiRay in axiRays)
            {

            }
        }

        public double CenterLength => CenterThickness;

        public AxiLens ReturnFlipped() => new AxiLens(OpticalMaterial, CenterThickness, OuterRadius, Radius2, Radius1);

        public string RenderMathematica()
        {
            Line2D lowerEdge = new Line2D(0, -OuterRadius, 0);
            Line2D upperEdge = new Line2D(0, OuterRadius, 0);

            Geo2D leftSurface;
            Point2D lowerLeftPoint;
            Point2D upperLeftPoint;
            if (Radius1.HasValue)
            {
                if (0 < Radius1.Value)
                {
                    //Convex

                    Circle2D circle = LeftConvexCircle();

                    lowerLeftPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).LeftMost();
                    upperLeftPoint = Geo2D.LineIntersectCircle(upperEdge, circle).LeftMost();

                    leftSurface = circle.GetArc(
                            (upperLeftPoint - circle.Center).Theta(),
                            (lowerLeftPoint - circle.Center).Theta() + 2 * Math.PI
                        );
                }
                else
                {
                    //Concave

                    Circle2D circle = LeftConcaveCircle();

                    lowerLeftPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).RightMost();
                    upperLeftPoint = Geo2D.LineIntersectCircle(upperEdge, circle).RightMost();

                    leftSurface = circle.GetArc(
                            (upperLeftPoint - circle.Center).Theta(),
                            (lowerLeftPoint - circle.Center).Theta()
                        );
                }   
            }
            else
            {
                lowerLeftPoint = new Point2D(0, -OuterRadius);
                upperLeftPoint = new Point2D(0, OuterRadius);

                leftSurface = new LineSegment2D(lowerLeftPoint, upperLeftPoint);
            }

            Geo2D rightSurface;
            Point2D lowerRightPoint;
            Point2D upperRightPoint;
            if (Radius2.HasValue)
            {
                if (0 < Radius2.Value)
                {
                    //Convex

                    Circle2D circle = new Circle2D(CenterThickness - Radius2.Value, 0, Radius2.Value);

                    lowerRightPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).RightMost();
                    upperRightPoint = Geo2D.LineIntersectCircle(upperEdge, circle).RightMost();

                    rightSurface = circle.GetArc(
                            (upperRightPoint - circle.Center).Theta(),
                            (lowerRightPoint - circle.Center).Theta()
                        );
                }
                else
                {
                    //Concave

                    Circle2D circle = new Circle2D(CenterThickness + Math.Abs(Radius2.Value), 0, Math.Abs(Radius2.Value));

                    lowerRightPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).LeftMost();
                    upperRightPoint = Geo2D.LineIntersectCircle(upperEdge, circle).LeftMost();

                    rightSurface = circle.GetArc(
                            (upperRightPoint - circle.Center).Theta(),
                            (lowerRightPoint - circle.Center).Theta() + 2 * Math.PI
                        );
                }
            }
            else
            {
                lowerRightPoint = new Point2D(CenterThickness, -OuterRadius);
                upperRightPoint = new Point2D(CenterThickness, OuterRadius);

                rightSurface = new LineSegment2D(lowerRightPoint, upperRightPoint);
            }

            LineSegment2D bottomSurface = new LineSegment2D(lowerLeftPoint, lowerRightPoint);
            LineSegment2D topSurface = new LineSegment2D(upperLeftPoint, upperRightPoint);

            var diagObjects = new List<IMathematicaRenderable>() { new Point2D(0, 0) };
            diagObjects.Add(lowerLeftPoint);
            diagObjects.Add(upperLeftPoint);
            diagObjects.Add(lowerRightPoint);
            diagObjects.Add(upperRightPoint);

            var objectsToRender = new List<IMathematicaRenderable>();
            //objectsToRender.AddRange(diagObjects);
            objectsToRender.AddRange(bottomSurface);
            objectsToRender.AddRange(topSurface);
            objectsToRender.AddRange(leftSurface);
            objectsToRender.AddRange(rightSurface);

            return new MathematicaRenderableMathematicaAdapter(objectsToRender.ToArray()).RenderMathematica();
        }
    }
}
