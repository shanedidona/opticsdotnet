namespace opticsdotnet.Lib
{
    public sealed class SphericalSingletFlatCurved : SphericalSinglet
    {
        public SphericalSingletFlatCurved(IOpticalMaterial opticalMaterial, double centerThickness, double outerRadius, double radius2) : base(opticalMaterial, centerThickness, outerRadius, null, radius2)
        {

        }
    }
}
