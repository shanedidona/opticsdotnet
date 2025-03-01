namespace opticsdotnet.Lib
{
    public static class IOUtil
    {
        public static string[][] ParseCSV(string path)//TODO: replace with a library for edge cases
        {
            var out1 = new List<string[]>();

            foreach (string line in File.ReadAllLines(path))
            {
                out1.Add(ParseCSVLine(line));
            }

            return out1.ToArray();
        }

        static string[] ParseCSVLine(string line)//TODO: replace with a library for edge cases
        {
            return line.Split(",").Select(x => x.Trim('"')).ToArray();
        }

        static (double[] Xs, double?[] Ys) ParsePhysicalData(string[][] splitLines)
        {
            double[] xs = new double[splitLines.Length];
            double?[] ys = new double?[splitLines.Length];

            for (int i = 0; i < splitLines.Length; i++)
            {
                xs[i] = double.Parse(splitLines[i][0]);

                if (i != 0 && xs[i - 1] >= xs[i])
                {
                    throw new NotSupportedException("Xs are not in order in ParsePhysicalData");
                }

                if (double.TryParse(splitLines[i][1], out double double1))
                {
                    ys[i] = double1;
                }
                else
                {
                    ys[i] = null;
                }
            }

            return (xs, ys);
        }
    }
}
