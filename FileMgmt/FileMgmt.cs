using System;
using System.IO;

namespace FileMgmt
{
    class FileMgmt
    {
        static void Main(string[] args)
        {
            string path = ".";
            string[] dirList = Directory.GetFiles(path, "*.dat");

            if (dirList.Length > 0)
            {
                foreach (string fileName in dirList)
                {
                    File.Delete(fileName);
                }
                Console.WriteLine(dirList.Length + " file(s) deleted.");
            }
        }
    }
}