namespace opticsdotnet.Lib
{
    public static class IOUtil
    {
        public static LinearSplineWithMinMax[] LinearSplinesWithMinMaxFromCSVFile(string path)
        {
            MathNet.Numerics.LinearAlgebra.Matrix<double> mat1 = MathNet.Numerics.Data.Text.DelimitedReader.Read<double>(path, false, ",", false);

            double[] xs = mat1.Column(0).ToArray();

            if (!Compare.ValidateIncreasing(xs))
            {
                throw new NotSupportedException("!Compare.ValidateIncreasing(xs) for " + path);
            }

            var out1 = new LinearSplineWithMinMax[mat1.ColumnCount - 1];
            for (int i = 0; i < out1.Length; i++)
            {
                double[] ys = mat1.Column(i + 1).ToArray();

                out1[i] = new LinearSplineWithMinMax(
                    MathNet.Numerics.Interpolation.LinearSpline.InterpolateSorted(xs, ys),
                    xs.First(),
                    xs.Last()
                );
            }

            return out1;
        }
    }
}
