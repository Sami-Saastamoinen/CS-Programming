using System;

namespace Lists
{
    class Lists
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Torvalds", "Musk", "Gates", "Buffet", "Dorsey" };

            names[0] = "Jobs";
            names[2] = "McAfee";
            names[4] = "Wozniak";

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}