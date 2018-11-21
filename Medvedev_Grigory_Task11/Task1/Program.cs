using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactAndPow;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial of number\n");

            Console.WriteLine("Enter number:");
            int numberF = int.Parse(Console.ReadLine());

            int factorial = FactAndPow.FactAndPow.Factorial(numberF);
            Console.WriteLine(factorial);

            Console.WriteLine("\n\nExponentiation\n");

            Console.WriteLine("Enter number:");
            double numberP = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter exp:");
            double exp = int.Parse(Console.ReadLine());

            double numberPow = FactAndPow.FactAndPow.Pow(numberP, exp);
            Console.WriteLine(factorial);

            Console.ReadKey();
        }
    }
}
