namespace opticsdotnet.Lib
{
    public sealed class SphericalSingletCurvedFlat: SphericalSinglet
    {
        public SphericalSingletCurvedFlat(IOpticalMaterial opticalMaterial, double centerThickness, double outerRadius, double radius1) : base(opticalMaterial, centerThickness, outerRadius, radius1, null)
        {

        }
    }
}
