using System;

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

            for (int i = 1; i <= N; i++)
            {
                Output(i, N);
            }

            Console.ReadKey();
        }

        static void Output(int M, int N)
        {
            //Console.Clear();

            for (int i = 1; i <= M; i++)
            {
                for (int k = M; k < N; k++)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j <= M - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j < i * 2; j++)
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
