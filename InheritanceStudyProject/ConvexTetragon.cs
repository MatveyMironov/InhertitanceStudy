using System;

namespace InheritanceStudyProject
{
    internal class ConvexTetragon : Tetragon
    {
        public ConvexTetragon(float a, float b, float c, float d, float angleAB, float angleCD) : base(a, b, c, d, angleAB, angleCD)
        {
            if (angleAB >= 180 || angleCD >= 180) throw new ArgumentOutOfRangeException("convex tetragon angles can,t be greater or equal to 180 degrees");
            //TODO: check if tetragon is convex
        }

        public override float CountArea()
        {
            return (_a * _b * (float)Math.Sin(_angleAB * Math.PI / 180) + _a * _b * (float)Math.Sin(_angleCD * Math.PI / 180)) / 2;
        }
    }
}
