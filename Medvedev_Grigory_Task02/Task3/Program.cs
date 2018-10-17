using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int N;
            while (!int.TryParse(Console.ReadLine(), out N) | !CheckPositive(N))
            {
                Console.WriteLine("Error. Invalid value. Expected positive number.");
            }

            Output(N);

            Console.ReadKey();
        }

        static void Output(int N)
        {
            Console.Clear();

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N-i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j < i*2; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        static bool CheckPositive(int value)
        {
            return value > 0;
        }
    }
}
