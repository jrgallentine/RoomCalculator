using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            { 
            double length = 0;
            double width = 0;
            double height = 0;
            string cont;

            Console.Write("Room Length (inches): ");
            string rlength = Console.ReadLine();
            length = double.Parse(rlength);

            Console.Write("Room Width (inches): ");
            string rwidth = Console.ReadLine();
                width = double.Parse(rwidth);

            Console.Write("Room Height (inches): ");
            string rheight = Console.ReadLine();
            height = double.Parse(rheight);

            Console.WriteLine($"Area: {width * length}");
            Console.WriteLine($"Perimeter: {(width * 2) + (length * 2)}");
            Console.WriteLine($"Volume: {width * height * length}");

            Console.WriteLine();
            Console.Write("Continue? (y/n): ");
            cont = Console.ReadLine();

            if (cont != "y") break; 
            }
                


            
        }
    }
}
