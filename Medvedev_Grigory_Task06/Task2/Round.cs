using System;

namespace Task2
{
    struct Point
    {
        public double x;
        public double y;
    } 

    class Round
    {
        public Round(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public Point Center { get; set; }

        double radius;

        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Radius must be a positive real number.");
                }
                radius = value;
            }
        }

        double lengthOfRound;

        public double LengthOfRound
        {
            get
            {
                lengthOfRound = 2 * Math.PI * radius;

                return lengthOfRound;
            }
        }

        double areaOfRound;

        public double AreaOfRound
        {
            get
            {
                areaOfRound = Math.PI * radius * radius;
                return areaOfRound;
            }
        }
    }
}
