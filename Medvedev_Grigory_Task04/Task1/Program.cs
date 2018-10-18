using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string originalString = Console.ReadLine();

            string pattern = "\\W+";
            string[] words = Regex.Split(originalString, pattern);           

            double AvarageLengthOfWords = CalculateAverageValue(words);

            Console.WriteLine($"\nAvarage Length Of Words = {AvarageLengthOfWords}");

            Console.ReadKey();
        }

        static double CalculateAverageValue(string[] words)
        {
            double sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                sum += words[i].Length;
            }

            return sum / words.Length;
        }
    }
}
