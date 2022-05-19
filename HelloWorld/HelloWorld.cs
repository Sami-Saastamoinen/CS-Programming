using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Syötä ikäsi, ole hyvä:");
            age = Convert.ToInt16(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Voit äänestää!");
            }
        }
    }
}