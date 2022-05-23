using System;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input = 0;

            while (sum < 200)
            {
                Console.Write("Sum is now {0}. Input: ", sum);
                input = Convert.ToInt32(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine("Reached 200. Sum was {0}.", sum);
        }
    }
}