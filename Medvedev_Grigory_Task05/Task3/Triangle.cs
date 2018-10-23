using System;

namespace Task3
{
    class Triangle
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        void checkPositive(double value, string error)
        {
            if (value <= 0)
            {
                throw new Exception($"Invalid value {error}. Expected positive real number.");
            }
        }

        public void CheckCorrectness()
        {
            if (a >= (b + c) || b >= (a + c) || c >= (a + b))
            {
                throw new Exception("The side of a triangle cannot be greater than the sum of " +
                    "its other two sides");
            }
        }
        
        double a;

        public double A
        {
            get => a;
            set
            {
                checkPositive(value, "a");
                a = value;
            }
        }

        double b;

        public double B
        {
            get => b;
            set
            {
                checkPositive(value, "b");
                b = value;
            }
        }

        double c;

        public double C
        {
            get => c;
            set
            {
                checkPositive(value, "c");
                c = value;
            }
        }

        public double GetPerimeter()
        {
            double perimeter;
            perimeter = a + b + c;

            return perimeter;
        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
    }
}
