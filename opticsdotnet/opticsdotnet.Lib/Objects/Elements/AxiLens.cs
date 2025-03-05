﻿namespace opticsdotnet.Lib
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
            if (Radius1.HasValue)
            {
                if (0 < Radius1.Value)
                {
                    //Convex

                    Circle2D circle = new Circle2D(Radius1.Value, 0, Radius1.Value);

                    leftSurface = circle;
                }
                else
                {
                    //Concave

                    Circle2D circle = new Circle2D(-Radius1.Value, 0, Radius1.Value);

                    leftSurface = circle;
                }   
            }
            else
            {
                leftSurface = new LineSegment2D(0, -OuterRadius, 0, OuterRadius);
            }

            IMathematicaRenderable rightSurface;
            if (Radius2.HasValue)
            {
                if (0 < Radius1.Value)
                {
                    //Convex

                    Circle2D circle = new Circle2D(CenterThickness - Radius2.Value, 0, Radius2.Value);

                    rightSurface = circle;
                }
                else
                {
                    //Concave

                    Circle2D circle = new Circle2D(CenterThickness + Radius2.Value, 0, Radius2.Value);

                    rightSurface = circle;
                }
            }
            else
            {
                rightSurface = new LineSegment2D(CenterThickness, -OuterRadius, 0, OuterRadius);
            }

            return new MathematicaRenderableMathematicaAdapter(lowerEdge, upperEdge, leftSurface, rightSurface).RenderMathematica();
        }
    }
}
