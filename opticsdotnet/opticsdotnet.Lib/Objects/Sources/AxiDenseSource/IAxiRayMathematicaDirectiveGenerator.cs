using opticsdotnet.Lib.Mathematica;

namespace opticsdotnet.Lib
{
    public interface IAxiDenseSourceMathematicaDirectiveGenerator
    {
        public MathematicaDirective[] GenerateAxiDenseSourceMathematicaDirectiveArray(
                int z0Index,
                int r0Index,
                int thetaIndex,
                int waveLengthIndex,
                double z0,
                double r0,
                double theta,
                double waveLength
            );
    }
}
