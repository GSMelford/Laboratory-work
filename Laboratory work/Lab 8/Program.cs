using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            Console.WriteLine(a.GetType());
            List<int> list = new List<int>();

            list.Add(a);

            Console.WriteLine(list[0].GetType());
            Console.ReadKey();
        }
    }
}
