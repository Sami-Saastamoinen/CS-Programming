using System;

namespace Lists
{
    class Lists
    {
        static void Main(string[] args)
        {
            int input = 0;
            List<int> nums = new List<int>();

            while (input >= 0)
            {
                Console.Write("Enter a number (negative to stop): ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input >= 0)
                {
                    nums.Add(input);
                }
            }

            Console.Write("Numbers that you entered: ");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
        }
    }
}