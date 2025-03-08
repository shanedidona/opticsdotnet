namespace opticsdotnet.Lib
{
    public sealed class AxiLens : IMathematicaRenderable
    {
        readonly double CenterThickness;
        readonly double OuterRadius;
        readonly double? Radius1;//Null means flat, positive is convex, and negative is concave
        readonly double? Radius2;//Null means flat, positive is convex, and negative is concave
        readonly IOpticalMaterial OpticalMaterial;

        public AxiLens(IOpticalMaterial opticalMaterial, double centerThickness, double outerRadius, double? radius1, double? radius2)
        {
            CenterThickness = centerThickness;
            OuterRadius = outerRadius;
            Radius1 = radius1;
            Radius2 = radius2;
            OpticalMaterial = opticalMaterial;
        }        

        public string RenderMathematica()
        {

            Line2D lowerEdge = new Line2D(0, -OuterRadius, 0);
            Line2D upperEdge = new Line2D(0, OuterRadius, 0);

            IMathematicaRenderable leftSurface;
            Point2D lowerLeftPoint;
            Point2D upperLeftPoint;
            if (Radius1.HasValue)
            {
                if (0 < Radius1.Value)
                {
                    //Convex

                    Circle2D circle = new Circle2D(Radius1.Value, 0, Radius1.Value);

                    lowerLeftPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).LeftMost();
                    upperLeftPoint = Geo2D.LineIntersectCircle(upperEdge, circle).LeftMost();

                    Arc2D arc = circle.GetArc(
                            (upperLeftPoint - circle.Center).Theta(),
                            (lowerLeftPoint - circle.Center).Theta() + 2 * Math.PI
                        );

                    leftSurface = arc;
                }
                else
                {
                    //Concave

                    Circle2D circle = new Circle2D(-Math.Abs(Radius1.Value), 0, Math.Abs(Radius1.Value));

                    lowerLeftPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).RightMost();
                    upperLeftPoint = Geo2D.LineIntersectCircle(upperEdge, circle).RightMost();

                    Arc2D arc = circle.GetArc(
                            (upperLeftPoint - circle.Center).Theta(),
                            (lowerLeftPoint - circle.Center).Theta()
                        );

                    leftSurface = arc;
                }   
            }
            else
            {
                lowerLeftPoint = new Point2D(0, -OuterRadius);
                upperLeftPoint = new Point2D(0, OuterRadius);

                leftSurface = new LineSegment2D(lowerLeftPoint, upperLeftPoint);
            }

            IMathematicaRenderable rightSurface;
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

                    Arc2D arc = circle.GetArc(
                            (upperRightPoint - circle.Center).Theta(),
                            (lowerRightPoint - circle.Center).Theta()
                        );

                    rightSurface = arc;
                }
                else
                {
                    //Concave

                    Circle2D circle = new Circle2D(CenterThickness + Math.Abs(Radius2.Value), 0, Math.Abs(Radius2.Value));

                    lowerRightPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).LeftMost();
                    upperRightPoint = Geo2D.LineIntersectCircle(upperEdge, circle).LeftMost();

                    Arc2D arc = circle.GetArc(
                            (upperRightPoint - circle.Center).Theta(),
                            (lowerRightPoint - circle.Center).Theta() + 2 * Math.PI
                        );

                    rightSurface = arc;
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
