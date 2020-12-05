using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 70;
            Console.WindowWidth = 110;
            int r = 30;
            int x = 0;
            for (int y = 0; y < r; ++y)
            {
                x = (int)Math.Round(2 * Math.Sqrt((Math.Pow(r, 2) - Math.Pow(y, 2))));

                Console.SetCursorPosition(x + r, y + r);
                Console.Write('.');
                Console.SetCursorPosition(x + r, -y + r);
                Console.Write('.');
                Console.SetCursorPosition(-x + 2 * r, -y + r);
                Console.Write('.');
                Console.SetCursorPosition(-x + 2 * r, y + r);
                Console.Write('.');
            }


            Console.SetCursorPosition(0, r * 2 + 2);
        }
    }
} 
