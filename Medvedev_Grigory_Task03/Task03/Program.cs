using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] ArrayOfInt = new int[n];

            WorkingWithArray.FillRandom(ArrayOfInt);
            WorkingWithArray.Output(ArrayOfInt);

            string OutputLineAsMaxValue = $"Max value = {WorkingWithArray.SearchMax(ArrayOfInt)}";
            Console.WriteLine(OutputLineAsMaxValue);

            string OutputLineAsMinValue = $"Min value = {WorkingWithArray.SearchMin(ArrayOfInt)}";
            Console.WriteLine(OutputLineAsMinValue);

            Console.WriteLine("Отсортированный массив:");
            WorkingWithArray.Output(WorkingWithArray.Sort(ArrayOfInt));

            Console.ReadKey();
        }

    }
}
