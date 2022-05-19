using System;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            string nums = "";
            for (int i = 0; i < Convert.ToInt16(args[0]); i++)
            {
                nums = nums + Convert.ToString(i + 1);
                Console.WriteLine(nums);
            }
        }
    }
}