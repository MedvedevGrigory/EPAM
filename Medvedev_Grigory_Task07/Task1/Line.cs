using System;

namespace Task1
{
    class Line : Figure
    {
        public Line(double length)
        {
            Length = length;
        }

        double length;

        public double Length
        {
            get => length;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Length of line must be positive.");
                }
                length = value;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"It's a line with length of {length}.");
        }
    }
}
