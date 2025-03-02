namespace opticsdotnet.Lib
{
    public static class Create
    {
        public static double[] Linspace(double a, double b, int n)//https://www.mathworks.com/help/matlab/ref/double.linspace.html
        {
            if (n < 2)
            {
                throw new NotSupportedException();
            }

            double spacing = (b - a) / (n - 1);

            var out1 = new double[n];
            out1[0] = a;
            out1[n - 1] = b;
            for (int i = 1; i < (n - 1); i++)
            {
                out1[i] = a + spacing * i;
            }

            return out1;
        }
    }
}
