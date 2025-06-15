using opticsdotnet.Lib;

namespace opticsdotnet.Testing.WaveLengthToRGB1
{
    public static class WaveLengthToRGB1
    {
        public static void WaveLengthToRGB1_1()
        {
            string saveDir = Path.Combine(Program.BaseSaveDir, "WaveLengthToRGB1");
            Directory.CreateDirectory(saveDir);

            double[] waveLengths = Create.Linspace(100, 1000, 2000);

            double[] r1s = new double[waveLengths.Length];
            double[] g1s = new double[waveLengths.Length];
            double[] b1s = new double[waveLengths.Length];

            for (int i = 0; i < waveLengths.Length; i++)
            {
                (r1s[i], g1s[i], b1s[i]) = PhysicsUtil.WaveLengthToRGB1(waveLengths[i]);
            }

            ScottPlot.Plot plot = new ScottPlot.Plot();
            plot.Add.Scatter(waveLengths, r1s, ScottPlot.Colors.Red);
            plot.Add.Scatter(waveLengths, g1s, ScottPlot.Colors.Green);
            plot.Add.Scatter(waveLengths, b1s, ScottPlot.Colors.Blue);

            plot.Save(Path.Combine(saveDir, "WaveLengthToRGB1.png"), 1920, 1080);
        }
    }
}
