using System;
using Task1;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            const int m = 3;
            const int l = 4;
            int[,,] ArrayOfInt = new int[n, m, l];

            WorkingWithArray.FillRandom(ArrayOfInt);
            Console.WriteLine("Original array:\n");
            WorkingWithArray.Output(ArrayOfInt);

            Console.WriteLine("\nChange array:\n");
            WorkingWithArray.Output(WorkingWithArray.ReplacePositiveWith0(ArrayOfInt));

            Console.ReadKey();
        }
    }
}
