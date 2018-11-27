using System;
using System.IO;

namespace Task2
{
    class ChangeFiles
    {
        const string pathRepos = @"..\..\repos";
        const string pathCopy = @"..\..\copy";
        const string filter = "*.txt";

        public static void SaveChange(object sender, FileSystemEventArgs e)
        {
            string time = DateTime.Now.ToString("dd-MM-yyyy hh.mm.ss");

            string toDir = $"{pathCopy}\\{time}";
            CopyDir(pathRepos, toDir);

            Console.WriteLine("Change saved");
        }
        
        private static void CopyDir(string fromDir, string toDir)
        {
            Directory.CreateDirectory(toDir);
            foreach (string file in Directory.GetFiles(fromDir, filter))
            {
                string fileCopy = toDir + "\\" + Path.GetFileName(file);
                File.Copy(file, fileCopy, true);
            }

            foreach (string dir in Directory.GetDirectories(fromDir))
            {
                CopyDir(dir, toDir + "\\" + Path.GetFileName(dir));
            }
        }

        internal static void Rollback(string time)
        {
            //string fromDir = pathCopy + "\\" + time;
            CopyDir(time, pathRepos);
        }

        internal static string[] GetDirectories()
        {
            return Directory.GetDirectories(pathCopy);
        }
    }
}
