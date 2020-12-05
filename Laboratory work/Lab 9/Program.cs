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
            Random random = new Random();
            while(true)
            {
                Console.ForegroundColor = (ConsoleColor)random.Next(16);
                Console.WriteLine("Mish Loh");
                Thread.Sleep(1000);
            }
        }
    }
} 
