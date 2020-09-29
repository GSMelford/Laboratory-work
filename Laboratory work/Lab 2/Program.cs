using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratory work No. 2");
            Console.Write("Enter the starting index: ");

            int start_index = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending index: ");

            int end_index = int.Parse(Console.ReadLine());

            double prod = 1;

            if (start_index <= end_index && start_index >= 0)
            {
                for (int k = start_index; k < end_index; k++)
                {
                    double temp;
                    temp = (Math.Pow(-1, k * k + k + 1) * k * k) / (2 * k * k + 5);
                    prod *= temp;
                }
                Console.WriteLine("Product of numbers = " + prod);
            }
            else
                Console.WriteLine("Error. Invalid indexes.");
        }
    }
}