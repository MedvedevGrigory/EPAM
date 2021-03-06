﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "There are two fundamentally different types of computers: analog and digital. The former type solver problems by using continuously changing data such as voltage. In current usage, the term \"computer\" usually refers to high-speed digital computers. These computers are playing an increasing role in all branches of the economy";

            string pattern = "\\W+";
            string[] words = Regex.Split(text, pattern);

            List<KeyValuePair<string, double>> wordsList = CountFrequinceWords(text, words);

            PrintWords(wordsList);

            Console.ReadKey();
        }

        static List<KeyValuePair<string, double>> CountFrequinceWords(string text, string[] words)
        {
            List<KeyValuePair<string, double>> wordsAndFrec = new List<KeyValuePair<string, double>>();
            for (int i = 0; i < words.Length; i++)
            {
                string pattern = $"\\b{words[i]}\\b";
                int numberOfWords = Regex.Matches(text, pattern, RegexOptions.IgnoreCase).Count;

                if (!wordsAndFrec.Any(word => word.Key == words[i]))
                {
                    double freq = (double)numberOfWords / (words.Length);
                    wordsAndFrec.Add(new KeyValuePair<string, double>(words[i], freq)); 
                }
            }

            return wordsAndFrec;
        }

        static void PrintWords(List<KeyValuePair<string, double>> wordsList)
        {
            for (int i = 0; i < wordsList.Count; i++)
            {
                Console.WriteLine($"{wordsList[i].Key,-13} {wordsList[i].Value*100:0.00}%");
            }
        }
    }
}
