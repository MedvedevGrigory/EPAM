using System;
using System.Diagnostics;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 10000;

            Stopwatch timer1 = Stopwatch.StartNew();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            long time1 = timer1.ElapsedMilliseconds;

            Stopwatch timer2 = Stopwatch.StartNew();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            long time2 = timer2.ElapsedMilliseconds;


            Console.WriteLine($"Time of work \"String\" = {time1}");
            Console.WriteLine($"Time of work \"StringBuilder\" = {time2}");
            Console.ReadKey();
        }
    }
}
