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
            var diagObjects = new List<IMathematicaRenderable>() { new Point2D(0, 0) };
            if (Radius1.HasValue)
            {
                if (0 < Radius1.Value)
                {
                    //Convex

                    Circle2D circle = new Circle2D(Radius1.Value, 0, Radius1.Value);

                    Point2D lowerLeftPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).LeftMost();
                    Point2D upperLeftPoint = Geo2D.LineIntersectCircle(upperEdge, circle).LeftMost();

                    diagObjects.Add(lowerLeftPoint);
                    diagObjects.Add(upperLeftPoint);

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

                    Point2D lowerLeftPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).RightMost();
                    Point2D upperLeftPoint = Geo2D.LineIntersectCircle(upperEdge, circle).RightMost();

                    diagObjects.Add(lowerLeftPoint);
                    diagObjects.Add(upperLeftPoint);

                    Arc2D arc = circle.GetArc(
                            (upperLeftPoint - circle.Center).Theta(),
                            (lowerLeftPoint - circle.Center).Theta()
                        );

                    leftSurface = arc;
                }   
            }
            else
            {
                leftSurface = new LineSegment2D(0, -OuterRadius, 0, OuterRadius);
            }

            IMathematicaRenderable rightSurface;
            if (Radius2.HasValue)
            {
                if (0 < Radius2.Value)
                {
                    //Convex

                    Circle2D circle = new Circle2D(CenterThickness - Radius2.Value, 0, Radius2.Value);

                    Point2D lowerRightPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).RightMost();
                    Point2D upperRightPoint = Geo2D.LineIntersectCircle(upperEdge, circle).RightMost();

                    diagObjects.Add(lowerRightPoint);
                    diagObjects.Add(upperRightPoint);

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

                    Point2D lowerRightPoint = Geo2D.LineIntersectCircle(lowerEdge, circle).LeftMost();
                    Point2D upperRightPoint = Geo2D.LineIntersectCircle(upperEdge, circle).LeftMost();

                    diagObjects.Add(lowerRightPoint);
                    diagObjects.Add(upperRightPoint);

                    Arc2D arc = circle.GetArc(
                            (upperRightPoint - circle.Center).Theta(),
                            (lowerRightPoint - circle.Center).Theta() + 2 * Math.PI
                        );

                    rightSurface = arc;
                }
            }
            else
            {
                rightSurface = new LineSegment2D(CenterThickness, -OuterRadius, CenterThickness, OuterRadius);
            }

            var objectsToRender = new List<IMathematicaRenderable>();
            objectsToRender.AddRange(diagObjects);
            objectsToRender.AddRange(lowerEdge);
            objectsToRender.AddRange(upperEdge);
            objectsToRender.AddRange(leftSurface);
            objectsToRender.AddRange(rightSurface);

            return new MathematicaRenderableMathematicaAdapter(objectsToRender.ToArray()).RenderMathematica();
        }
    }
}
