using System;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            int[] nums = new int[args.Length];
            int idx = 0;
            int temp = 0;
            foreach (string arg in args)
            {
                nums[idx] = Convert.ToInt32(arg);
                idx++;
            }
            for (int write = 0; write < nums.Length; write++)
            {
                for (int sort = 0; sort < nums.Length - 1; sort++)
                {
                    if (nums[sort] > nums[sort + 1])
                    {
                        temp = nums[sort + 1];
                        nums[sort + 1] = nums[sort];
                        nums[sort] = temp;
                    }
                }
            }
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
        }
    }
}