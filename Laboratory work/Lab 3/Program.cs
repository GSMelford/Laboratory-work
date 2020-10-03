using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratory work No. 3");

            Console.WriteLine("Enter the coordinates of the point that lies inside: ");
            Console.Write("x: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the point in the upper corner: ");
            Console.Write("x1: ");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the point in the bottom corner: ");
            Console.Write("x2: ");
            int x2 = Int32.Parse(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = Int32.Parse(Console.ReadLine());

            if (x > x1 && x < x2 && y < y1 && y > y2)
                Console.WriteLine("It is truth");
            else
                Console.WriteLine("It is a lie!");
        }
    }
}
