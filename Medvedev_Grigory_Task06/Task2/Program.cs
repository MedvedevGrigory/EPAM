using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point center = new Point();

            Console.WriteLine("Enter x:");
            center.x = doubleTryParse(center.x);

            Console.WriteLine("Enter y:");
            center.y = doubleTryParse(center.y);

            Console.WriteLine("Enter inner radius:");
            double innerRadius = new double();
            innerRadius = doubleTryParse(innerRadius);

            Console.WriteLine("Enter inner radius:");
            double outerRadius = new double();
            outerRadius = doubleTryParse(outerRadius);

            try
            {
                Ring ring = new Ring(center, innerRadius, outerRadius);
                ring.checkCorrectly();

                Console.WriteLine($"\nCenter - ({ring.Center.x},{ring.Center.y})\n" +
                    $"Inner radius = {ring.InnerRadius}\n" +
                    $"Outer radius = {ring.OuterRadius}\n" +
                    $"Total border length = {ring.TotalBorderLength}\n" +
                    $"Area of ring = {ring.AreaOfRing}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        static double doubleTryParse(double value)
        {
            if (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid value. Expected real number.");
            }

            return value;
        }
    }
}
