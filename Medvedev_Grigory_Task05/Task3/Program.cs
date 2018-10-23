using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            double a = new double();
            a = doubleTryParse(a);

            Console.WriteLine("Enter b:");
            double b = new double();
            b = doubleTryParse(b);

            Console.WriteLine("Enter c:");
            double c = new double();
            c = doubleTryParse(c);

            try
            {
                Triangle triangle = new Triangle(a, b, c);
                triangle.CheckCorrectness();

                Console.WriteLine($"\nSide a = {triangle.A}\n" +
                    $"Side b = {triangle.B}\n" +
                    $"Side c = {triangle.C}\n" +
                    $"Perimeter = {triangle.GetPerimeter()}\n" +
                    $"Area = {triangle.GetArea()}");
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
