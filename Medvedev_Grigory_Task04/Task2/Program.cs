using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string originalString = Console.ReadLine();

            Console.WriteLine("Enter second string");
            string stringWithLetters = Console.ReadLine();

            char[] letters = SplitStringIntoLetters(stringWithLetters);

            string changeString = DoubleLetters(originalString,letters);
            
            Console.WriteLine(changeString);

            Console.ReadKey();
        }

        static char[] SplitStringIntoLetters(string stringWithLetters)
        {
            char[] letters = new char[stringWithLetters.Length];
            for (int i = 0; i < stringWithLetters.Length; i++)
            {
                letters[i] = stringWithLetters[i];
            }

            return letters;
        }

        static string DoubleLetters(string originalString ,char[] letters)
        {
            string changeString = originalString;
            for (int i = 0; i < letters.Length; i++)
            {
                changeString = Regex.Replace(changeString, letters[i].ToString(), $"{letters[i]}{letters[i]}");
            }

            return changeString;
        }
    }
}
