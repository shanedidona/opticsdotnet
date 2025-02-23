﻿namespace opticsdotnet.Lib
{
    public sealed class Circle2D : Geo2D
    {
        public Point2D Center { get; set; }
        public double R { get; set; }

        public override string RenderMathematica()
        {
            return MathematicaUtil.RenderMathematicaFunction(
                    "Circle",
                    MathematicaUtil.Render(Center.X, Center.Y),
                    new DoubleMathematicaAdapter(R).RenderMathematica()
                );
        }
    }
}
