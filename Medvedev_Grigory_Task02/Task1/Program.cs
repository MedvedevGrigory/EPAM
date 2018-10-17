using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating the area of a rectangle");

            int a = InputSide("a");
            int b = InputSide("b");

            if (CheckPositive(a) & CheckPositive(b))
            {
                int Area = a * b;
                Console.WriteLine($"The area of a rectangle = {Area}");
            }
            else
            {
                Console.WriteLine("Error. One or more sides have a non-positive value.");
            }

            Console.ReadKey();
        }

        static int InputSide(string SideName)
        {
            Console.WriteLine($"Enter side {SideName}:");
            int side;
            while (!int.TryParse(Console.ReadLine(), out side))
            {
                Console.WriteLine("Error. Invalid value. Expected positive number.");
            }

            return side;
        }

        static bool CheckPositive(int value)
        {
            return value > 0;
        }
    }
}
