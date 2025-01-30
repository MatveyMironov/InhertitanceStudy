using System;

namespace InheritanceStudyProject
{
    internal abstract class Tetragon
    {
        protected readonly float _a;
        protected readonly float _b;
        protected readonly float _c;
        protected readonly float _d;
        protected readonly float _angleAB;
        protected readonly float _angleCD;

        protected Tetragon(float a, float b, float c, float d, float angleAB, float angleCD)
        {
            if (a <= 0 || b <= 0 || c <= 0 || d <= 0) throw new ArgumentOutOfRangeException("tetragon sides can,t be less or equal to 0");
            if (angleAB <= 0 || angleCD <= 0) throw new ArgumentOutOfRangeException("tetragon angles can,t be less or equal to 0 degrees");
            if (angleAB == 180 || angleCD == 180) throw new ArgumentOutOfRangeException("tetragon angles can,t be equal to 180 degrees");
            if (!(a * a + b * b - a * b * Math.Cos(angleAB) == c * c + d * d - c * d * Math.Cos(angleCD))) throw new ArgumentException("this configuration of sides and angles doesn't produce tetragon");

            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _angleAB = angleAB;
            _angleCD = angleCD;
        }

        public virtual float CountPerimeter()
        {
            return _a + _b + _c + _d;
        }

        public abstract float CountArea();
    }
}
