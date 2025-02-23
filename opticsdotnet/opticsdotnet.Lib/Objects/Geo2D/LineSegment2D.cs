namespace opticsdotnet.Lib
{
    public sealed class LineSegment2D : Geo2D
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }


        public override string RenderMathematica()
        {
            return MathematicaUtil.RenderMathematicaFunction(
                    "Line",
                    MathematicaUtil.RenderMathematicaAssumeAlreadyMathematica(
                            MathematicaUtil.RenderMathematica(X1, Y1),
                            MathematicaUtil.RenderMathematica(X2, Y2)
                        )
                );
        }
    }
}
