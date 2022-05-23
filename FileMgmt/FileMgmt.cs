using System;
using System.IO;

namespace FileMgmt
{
    class FileMgmt
    {
        static void Main(string[] args)
        {
            //string fileName, content;

            Console.Write("Tiedostonimi: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Sisalto tiedostolle {0}:", fileName);
            string content = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(content);
                sw.Close();
            }
        }
    }
}