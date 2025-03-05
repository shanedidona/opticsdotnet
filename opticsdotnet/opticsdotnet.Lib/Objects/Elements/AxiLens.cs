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



















            return MathematicaUtil.Nothing;
        }
    }
}
