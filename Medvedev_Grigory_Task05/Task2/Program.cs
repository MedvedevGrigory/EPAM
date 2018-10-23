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

            Console.WriteLine("Enter radius:");
            double radius = new double();
            radius = doubleTryParse(radius);

            try
            {
                Round round = new Round(center, radius);

                Console.WriteLine($"\nCenter - ({round.Center.x},{round.Center.y})\n" +
                    $"Radius = {round.Radius}\n" +
                    $"Length of round = {round.LengthOfRound}\n" +
                    $"Area of round = {round.AreaOfRound}");
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
