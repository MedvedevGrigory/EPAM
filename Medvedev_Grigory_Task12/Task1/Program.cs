using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task1
{
    class Program
    {
        public static string CurrentPath(string name)
        {
            return Path.Combine(Environment.CurrentDirectory, name);
        }

        public static List<int> ReadInt(string name)
        {
            string path = CurrentPath(name);
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            List<int> result = new List<int>();

            using (StreamReader sr = File.OpenText(path))
            {
                int numberStr = 0;
                while (!sr.EndOfStream)
                {
                    numberStr++;
                    if (!int.TryParse(sr.ReadLine(), out int currentValue))
                    {
                        throw new FormatException($"Invalid value in lune №{numberStr}");
                    }

                    result.Add(currentValue);
                }
            }

            return result;
        }

        public static void SqrInts(ref List<int> ints)
        {
            ints = ints.Select(i => i * i).ToList();
        }

        static public void WriteInt(string name, List<int> ints)
        {
            string path = CurrentPath(name);
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            using (StreamWriter sr = new StreamWriter(path))
            {
                foreach (var i in ints)
                {
                    sr.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                const string name = "disposable_task_file.txt";
                List<int> ints = ReadInt(name);
                SqrInts(ref ints);
                WriteInt(name, ints);
                Console.WriteLine("File change.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}