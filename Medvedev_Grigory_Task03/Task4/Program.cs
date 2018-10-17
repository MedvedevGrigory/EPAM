using System;
using Task1;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            const int m = 3;
            int[,] ArrayOfInt = new int[n,m];

            WorkingWithArray.FillRandom(ArrayOfInt);
            WorkingWithArray.Output(ArrayOfInt);

            int Sum = WorkingWithArray.SumOfElementsOnEvenPositions(ArrayOfInt);
            Console.WriteLine($"SumOfElementsOnEvenPositions = {Sum}");

            Console.ReadKey();
        }
    }
}
