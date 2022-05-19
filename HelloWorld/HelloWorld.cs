using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            string answer;

            Console.Write("What is your favourite fruit? ");
            answer = Console.ReadLine();
            Console.WriteLine("Your favourite fruit is " + answer);
        }
    }
}