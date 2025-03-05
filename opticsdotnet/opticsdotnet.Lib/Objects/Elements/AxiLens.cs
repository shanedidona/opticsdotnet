namespace opticsdotnet.Lib
{
    public sealed class AxiLens : IMathematicaRenderable
    {
        readonly double CenterThickness;
        readonly double OuterRadius;
        readonly double? Radius1;//Null means flat
        readonly double? Radius2;//Null means flat
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
                Circle2D circle = new Circle2D(-Radius1.Value, 0, Radius1.Value);

                leftSurface = circle;
            }
            else
            {
                leftSurface = new LineSegment2D(0, -OuterRadius, 0, OuterRadius);
            }

            IMathematicaRenderable rightSurface;
            if (Radius2.HasValue)
            {
                Circle2D circle = new Circle2D(CenterThickness + Radius2.Value, 0, Radius2.Value);

                rightSurface = circle;
            }
            else
            {
                rightSurface = new LineSegment2D(CenterThickness, -OuterRadius, 0, OuterRadius);
            }

            return new MathematicaRenderableMathematicaAdapter(lowerEdge, upperEdge, leftSurface, rightSurface).RenderMathematica();
        }
    }
}
