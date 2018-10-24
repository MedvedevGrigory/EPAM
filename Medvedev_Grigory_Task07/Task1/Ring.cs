using System;

namespace Task1
{
    class Ring : Round
    {
        public Ring(double innerRadius, double outerRadius) : base(innerRadius)
        {
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }

        public double InnerRadius { get => Radius; set => Radius = value; }

        double outerRadius;

        public double OuterRadius
        {
            get => outerRadius;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Radius must be positive.");
                }
                outerRadius = value;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"It's a ring with a inner radius of {InnerRadius} and outer radius of {outerRadius}.");
        }
    }
}
