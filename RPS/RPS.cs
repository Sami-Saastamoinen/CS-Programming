using System;

namespace RPS
{
    class RPS
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int choice = 0;
            int cpu = 0;

            do
            {
                Console.WriteLine("Rock-Paper-Scissors. Choose 1-4.\n1) Rock 2) Paper 3) Scissors 4) Quit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4) { return; }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You chose: Rock!");
                        break;
                    case 2:
                        Console.WriteLine("You chose: Paper!");
                        break;
                    case 3:
                        Console.WriteLine("You chose: Scissors!");
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        continue;
                }
                cpu = random.Next(1, 4);
                switch (cpu)
                {
                    case 1:
                        Console.WriteLine("CPU chose: Rock!");
                        break;
                    case 2:
                        Console.WriteLine("CPU chose: Paper!");
                        break;
                    case 3:
                        Console.WriteLine("CPU chose: Scissors!");
                        break;
                    default:
                        break;
                }
                string result = (choice, cpu) switch
                {
                    (1, 2) => "You Lost!",
                    (1, 3) => "You Won!",
                    (2, 1) => "You Won!",
                    (2, 3) => "You Lost",
                    (3, 1) => "You Lost",
                    (3, 2) => "You Won!",
                    (_, _) => "It's a Tie!"
                };
                Console.WriteLine(result);
            } while (choice != 4);
        }
    }
}