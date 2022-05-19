using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("Choose:\n1) Water\n2) Juice\n3) Lemonade\n4) Quit");
            choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose Water.");
                    break;
                case 2:
                    Console.WriteLine("You chose Juice.");
                    break;
                case 3:
                    Console.WriteLine("You chose Lemonade.");
                    break;
                case 4:
                    Console.WriteLine("Quit!");
                    break;
                default:
                    break;
            }
        }
    }
}