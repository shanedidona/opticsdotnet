namespace opticsdotnet.Lib
{
    public partial class SphericalSinglet : IAxiOpticalElement
    {
        Circle2D LeftConvexCircle() => new Circle2D(Radius1.Value, 0, Radius1.Value);
        Circle2D LeftConcaveCircle() => new Circle2D(-Math.Abs(Radius1.Value), 0, Math.Abs(Radius1.Value));
    }
}