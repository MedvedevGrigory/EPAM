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

        private double radius;

        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Radius must be a positive integer.");
                }
                radius = value;
            }
        }

        private double lengthOfRound;

        public double LengthOfRound
        {
            get
            {
                lengthOfRound = 2 * Math.PI * radius;

                return lengthOfRound;
            }
        }

        private double areaOfRound;

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
