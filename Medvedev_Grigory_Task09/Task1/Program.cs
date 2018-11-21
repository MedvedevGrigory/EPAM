using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            List<int> list = new List<int>(n);
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            int listResult = RemoveEachSecondItem(list);
            Console.WriteLine($"Result with List - {listResult}");

            LinkedList<int> linkedList = new LinkedList<int>(list);

            int linkedListResult = RemoveEachSecondItem(linkedList);
            Console.WriteLine($"Result with LinkedList - {linkedListResult}");

            Console.ReadKey();
        }

        static int RemoveEachSecondItem(IEnumerable<int> list)
        {
            bool isOdd = true;

            while (list.Count() > 1)
            {
                List<int> list2 = new List<int>();
                foreach (var item in list)
                {
                    if (isOdd)
                    {
                        list2.Add(item);
                    }
                    isOdd = !isOdd;
                }
                list = new List<int>(list2);
            }

            return list.First();
        }

        // ref out parameters
        // ref parameter for reference types
        //
    }
}
