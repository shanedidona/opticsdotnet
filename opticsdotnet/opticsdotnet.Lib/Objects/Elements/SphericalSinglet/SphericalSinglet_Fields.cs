namespace opticsdotnet.Lib
{
    public partial class SphericalSinglet : IAxiOpticalElement
    {
        protected double CenterThickness;
        protected double OuterRadius;
        protected double? Radius1;//Null means flat, positive is convex, and negative is concave
        protected double? Radius2;//Null means flat, positive is convex, and negative is concave
        protected IOpticalMaterial OpticalMaterial;
    }
}