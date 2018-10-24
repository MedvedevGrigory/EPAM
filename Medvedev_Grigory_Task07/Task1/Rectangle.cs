using System;

namespace Task1
{
    class Rectangle : Figure
    {
        public Rectangle(double weigth, double heigth)
        {
            Weigth = weigth;
            Heigth = heigth;
        }

        void checkPositive(double value, string error)
        {
            if (value <= 0)
            {
                throw new Exception($"{error} must be positive.");
            }
        }

        double weigth;

        public double Weigth
        {
            get => weigth;
            set
            {
                checkPositive(value, "Weigth");
                weigth = value;
            }
        }

        double heigth;

        public double Heigth
        {
            get => heigth;
            set
            {
                checkPositive(value, "Heigth");
                heigth = value;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"It's a rectangle with a weigth of {weigth} and heigth of {heigth}.");
        }
    }
}
