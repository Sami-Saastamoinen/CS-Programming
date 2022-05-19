using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt16(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("First number is bigger.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Second number is bigger.");
            }
            else
            {
                Console.WriteLine("Numbers are equal.");
            }
        }
    }
}