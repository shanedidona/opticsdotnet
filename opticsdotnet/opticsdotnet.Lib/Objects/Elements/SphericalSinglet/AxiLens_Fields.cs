namespace opticsdotnet.Lib
{
    public sealed partial class SphericalSinglet : IAxiOpticalElement
    {
        readonly double CenterThickness;
        readonly double OuterRadius;
        readonly double? Radius1;//Null means flat, positive is convex, and negative is concave
        readonly double? Radius2;//Null means flat, positive is convex, and negative is concave
        readonly IOpticalMaterial OpticalMaterial;
    }
}