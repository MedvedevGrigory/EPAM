using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    delegate int Compare(string s1, string s2);

    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "aa", "c", "b", "d" };

            Compare compare = new Compare(CompareByLength);         

            Sort(strings, compare);

            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static int CompareByAlphabet(string s1, string s2)
        {
            return s1.CompareTo(s2);
        }

        static int CompareByLength(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return 1;
            }

            if (s1.Length < s2.Length)
            {
                return -1;
            }

            return CompareByAlphabet(s1, s2);
        }

        static void Sort(string[] strings, Compare compare)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings.Length-1; j++)
                {
                    if (compare(strings[j], strings[j + 1]) > 0)
                    {
                        string boofer = strings[j];
                        strings[j] = strings[j + 1];
                        strings[j + 1] = boofer;
                    }
                }
            }
        }
    }
}
