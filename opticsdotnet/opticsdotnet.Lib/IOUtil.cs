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
    }
}
