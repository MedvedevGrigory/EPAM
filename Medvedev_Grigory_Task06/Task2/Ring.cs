using System;

namespace Task2
{
    class Ring : Round
    {
        public Ring(Point center, double innerRadius, double outerRadius) : base(center, innerRadius)
        {
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }

        public double InnerRadius { get => Radius; set => Radius = value; }

        private double outerRadius;

        public double OuterRadius
        {
            get => outerRadius;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Radius must be a positive real number.");
                }
                outerRadius = value;
            }
        }

        double areaOfRing;

        public double AreaOfRing
        {
            get
            {
                areaOfRing = Math.PI * (outerRadius * outerRadius - InnerRadius * InnerRadius);

                return areaOfRing;
            }
        }

        double totalBorderLength;

        public double TotalBorderLength
        {
            get
            {
                totalBorderLength = 2 * Math.PI * (outerRadius + InnerRadius);

                return totalBorderLength;
            }
        }

        public void checkCorrectly()
        {
            if (InnerRadius > outerRadius)
            {
                throw new Exception("Inner radius must be greater then outer radius.");
            }
        }
    }
}
