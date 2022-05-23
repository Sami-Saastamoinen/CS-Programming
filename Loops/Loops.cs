using System;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            char[] characters = { 'L', 'e', 'a', 'r', 'n', ' ', 'C', '#', '!' };

            foreach (char character in characters)
            {
                Console.Write(character);
            }
        }
    }
}