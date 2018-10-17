using System;
using Task1;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] ArrayOfInt = new int[n];

            WorkingWithArray.FillRandom(ArrayOfInt);
            WorkingWithArray.Output(ArrayOfInt);

            int Sum = WorkingWithArray.SumNonnegativeElements(ArrayOfInt);
            Console.WriteLine($"SumNonnegativeElements = {Sum}");

            Console.ReadKey();
        }
    }
}
