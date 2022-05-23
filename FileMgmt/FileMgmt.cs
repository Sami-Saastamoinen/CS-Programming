using System;
using System.IO;

namespace FileMgmt
{
    class FileMgmt
    {
        static void Main(string[] args)
        {
            string fileName, content;
            if (args.Length == 0)
            {
                Console.WriteLine("No file name given!");
                return;
            }
            else
            {
                fileName = args[0];
            }
            if (File.Exists(fileName))
            {
                content = File.ReadAllText(fileName);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }
    }
}