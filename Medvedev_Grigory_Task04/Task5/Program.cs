using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text with HTML-tegs:");
            string text = Console.ReadLine();

            string pattern = @"<[\w\W]*>";
            string changeText = Regex.Replace(text, pattern, "_");

            Console.WriteLine(changeText);

            Console.ReadKey();
        }
    }
}
