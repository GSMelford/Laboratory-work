using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double g = 9.8;
            double t = 0;

            Console.WriteLine("Laboratory work No. 1");
            Console.Write("Enter starting speed: ");

            double v = Double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");

            double h = Double.Parse(Console.ReadLine());
            // h = v0*t + (g*t^2)/2 => (g/2)*t^2+v0*t-h=0

            if (v == 0)
            {
                t = Math.Sqrt((2 * h) / g);
            }
            else
            {
                double D = Math.Sqrt(v * v + (2 * g * h));
                if (D == 0)
                {
                    t = -v / g;
                }
                else
                {
                    t = (-v + D) / g;
                    if (t < 0)
                    {
                        t = (-v - D) / g;
                    }
                }
            }

            Console.WriteLine("The fall time was: " + t + " time units.");
        }
    }
}
