namespace opticsdotnet.Lib
{
    public static class IOUtil
    {
        public static LinearSplineWithMinMax LinearSplineWithMinMaxFromCSVFile(string path)
        {
            MathNet.Numerics.LinearAlgebra.Matrix<double> mat1 = MathNet.Numerics.Data.Text.DelimitedReader.Read<double>(path, false, ",", false);

            double[] xs = mat1.Column(0).ToArray();

            if (!Compare.ValidateIncreasing(xs))
            {
                throw new NotSupportedException("!Compare.ValidateIncreasing(xs) for " + path);
            }

            double[] ys = mat1.Column(1).ToArray();

            return new LinearSplineWithMinMax(
                    MathNet.Numerics.Interpolation.LinearSpline.InterpolateSorted(xs, ys),
                    xs.First(),
                    xs.Last()
                );
        }
    }
}
