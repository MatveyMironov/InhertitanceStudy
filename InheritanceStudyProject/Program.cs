using System;

namespace InheritanceStudyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tetragon convexTetragon = new ConvexTetragon(3, 3, 3, 3, 60, 60);
            Tetragon parallelogram = new Parallelogram(8, 4, 42);
            Tetragon rhombus = new Rhombus(3, 73);
            Tetragon square = new Square(2);
            Tetragon rectangle = new Rectangle(5, 7);

            WriteTetragon(convexTetragon, nameof(convexTetragon));
            WriteTetragon(parallelogram, nameof(parallelogram));
            WriteTetragon(rhombus, nameof(rhombus));
            WriteTetragon(square, nameof(square));
            WriteTetragon(rectangle, nameof(rectangle));

            Console.ReadLine();
        }

        private static void WriteTetragon(Tetragon tetragon, string name)
        {
            Console.WriteLine(name);
            Console.WriteLine(tetragon.CountPerimeter());
            Console.WriteLine(tetragon.CountArea());
            Console.WriteLine();
        }
    }
}
