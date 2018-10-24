using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticalProgression arithmeticalProgression = new ArithmeticalProgression(2, 2);
            PrintSeries(arithmeticalProgression, 5);

            double[] series = new double[] { 1, 2, 3, 4, 5, 6, 7 };
            List list = new List(series);
            PrintSeries(list, 5);

            Console.ReadKey();
        }

        public static void PrintSeries(IIndexableSeries series, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(series[i]);
            }
        }
    }
}
