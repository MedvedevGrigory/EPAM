using System;
using System.IO;

namespace Task2
{
    class Program
    {
        const string pathRepos = @"..\..\repos";
        const string pathCopy = @"..\..\copy";
        const string filter = "*.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Selected mode");
            Console.WriteLine("1. Observation");
            Console.WriteLine("2. Rollback");

            switch( int.Parse(Console.ReadLine()))
            {
                case 1:
                    Observation();
                    break;
                case 2:
                    Rollback();
                    break;
            }

            Console.ReadKey();
        }

        private static void Observation()
        {
            try
            {
                FileSystemWatcher watcher = new FileSystemWatcher(pathRepos)
                {
                    Filter = filter,
                    IncludeSubdirectories = true
                };

                watcher.Changed += new FileSystemEventHandler(ChangeFiles.SaveChange);
                watcher.Deleted += new FileSystemEventHandler(ChangeFiles.SaveChange);
                watcher.Renamed += new RenamedEventHandler(ChangeFiles.SaveChange);
                watcher.EnableRaisingEvents = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private static void Rollback()
        {
            //try
            //{
                Console.WriteLine("Choose a time to recoil:");
                string[] directories = ChangeFiles.GetDirectories();
                OutputNameOfCataloges(directories);
                int number = int.Parse(Console.ReadLine());

                ChangeFiles.Rollback(directories[number-1]);
                Console.WriteLine("Rollback complited.");
            /*}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
        }

        private static void OutputNameOfCataloges(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i+1}.{Path.GetFileNameWithoutExtension(array[i])}");
            }
        }
    }
}