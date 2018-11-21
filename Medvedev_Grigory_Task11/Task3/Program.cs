using NetBasicsDemo;
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
            var hashs = new List<int>();
            for (var i = 0; i < 1000; i++)
            {
                for(var j = 0; j < 1000; j++)
                {
                    var point = new TwoDPointWithHash(i, j);
                    hashs.Add(point.GetHashCode());
                }
            }

            var uniqueValues = hashs.Distinct().ToList();

            double errors = hashs.Count - uniqueValues.Count;

            double proc = errors / hashs.Count * 100;

            Console.WriteLine(uniqueValues.Count);
            Console.WriteLine(errors);
            Console.WriteLine(proc);

            //12 task FileSystemWatcher
        }
    }
}
