using System;

namespace Task1
{
    class Round : Figure
    {
        public Round(double radius)
        {
            Radius = radius;
        }

        double radius;

        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Radius must be positive.");
                }
                radius = value;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"It's a round with a radius of {radius}.");
        }
    }
}
