using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Lib
{
    public sealed class ColorFromWaveLength : IAxiDenseSourceMathematicaDirectiveGenerator
    {
        public ColorFromWaveLength()
        {

        }

        public MathematicaDirective[] GenerateAxiDenseSourceMathematicaDirectiveArray(int z0Index, int r0Index, int thetaIndex, int waveLengthIndex, double z0, double r0, double theta, double waveLength)
        {
            (double r, double g, double b) = PhysicsUtil.WaveLengthToRGB1(waveLength);

            return new MathematicaDirective[]
            {
                new RGBColor(r,g,b)
            };
        }
    }
}
