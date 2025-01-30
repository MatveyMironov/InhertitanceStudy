using System;

namespace InheritanceStudyProject
{
    internal class Parallelogram : ConvexTetragon
    {
        public Parallelogram(float a, float b, float angleAB) : base(a, b, a, b, angleAB, angleAB)
        {
            
        }
    }
}
