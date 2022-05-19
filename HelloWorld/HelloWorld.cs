using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Find quadrant of a point(x,y):");
            Console.Write("X-coordinate: ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Y-coordinate: ");
            y = Convert.ToInt16(Console.ReadLine());
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Point ({0},{1}) is in origo.", x, y);
            }
            else if (x < 0)
            {
                if (y < 0)
                {
                    Console.WriteLine("Point ({0},{1}) is on quadrant 3.", x, y);
                }
                else
                {
                    Console.WriteLine("Point ({0},{1}) is on quadrant 2.", x, y);
                }
            }
            else
            {
                if (y < 0)
                {
                    Console.WriteLine("Point ({0},{1}) is on quadrant 4.", x, y);
                }
                else
                {
                    Console.WriteLine("Point ({0},{1}) is on quadrant 1.", x, y);
                }
            }
        }
    }
}