using System;
using System.IO;

namespace FileMgmt
{
    class FileMgmt
    {
        static void Main(string[] args)
        {
            string path = ".";
            string[] dirList = Directory.GetFiles(path);

            if (dirList.Length > 0)
            {
                foreach (string fileName in dirList)
                {
                    Console.WriteLine(fileName);
                }
            }
        }
    }
}