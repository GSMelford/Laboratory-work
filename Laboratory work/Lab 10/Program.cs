using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1234;
            Console.WriteLine($"Расширение для типа Int: {number} => {number.IntReverse()}");
            string str = "jhagesfkj";
            Console.WriteLine($"Расширение для типа String: {str} => {str.StringReverse()}");
            string strDouble = "1sdafsed.sdfgas";
            Console.WriteLine($"Расширение для типа Int: {strDouble} => {strDouble.StringDoubleReverse()}");
            double number2 = 12.34;
            Console.WriteLine($"Расширение для типа Int: {number2} => {number2.DoubleReverse()}");

            int[] array = new int[] { 4,6,23,2,87,1,89,9,3};
            int[] tempArray = array.ArrayReverse();
            Console.Write("Расширение для типа Int[]: ");
            foreach (var value in array)
                Console.Write(value + " ");

            Console.Write(" => ");

            foreach (var value in tempArray)
                Console.Write(value + " ");

            Console.Write("\nРасширение для типа Int[] Сортировка: ");
            tempArray = array.ArraySort();
            foreach (var value in tempArray)
                Console.Write(value + " ");
            Console.ReadKey();
        }
    }
}
