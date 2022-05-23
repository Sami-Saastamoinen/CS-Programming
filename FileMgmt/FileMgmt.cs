using System;
using System.IO;

namespace FileMgmt
{
    class FileMgmt
    {
        static void Main(string[] args)
        {
            //string fileName, content;

            Console.Write("File name: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter the content {0}:", fileName);
            string content = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine(content);
                sw.Close();
            }
        }
    }
}