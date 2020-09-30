using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratory work No. 6");

            Console.Write("Use for loops (0) or recursion (1): ");
            int select = Int32.Parse(Console.ReadLine());

            switch (select)
            {
                case 0:
                    Console.Write("Enter the number: ");
                    Console.WriteLine("Reverse: " + Reverse(Int32.Parse(Console.ReadLine())));

                    Console.Write("Enter the string: ");
                    Console.WriteLine("Reverse: " + Reverse(Console.ReadLine()));

                    Console.Write("Enter a floating point number: ");
                    Console.WriteLine("Reverse: " + Reverse(Double.Parse(Console.ReadLine())));

                    Console.Write("Enter a floating point string: ");
                    Console.WriteLine("Reverse: " + ReverseStringDouble(Console.ReadLine()));

                    break;
                case 1:
                    Console.Write("Enter the number: ");
                    Console.WriteLine("Reverse: " + RecurseReverse(Int32.Parse(Console.ReadLine()),0));

                    /*Console.WriteLine("Reverse: ");
                    RecurseReverse(Int32.Parse(Console.ReadLine()));*/

                    Console.Write("Enter the string: ");
                    Console.WriteLine("Reverse: " + RecurseReverse(Console.ReadLine()));

                    Console.Write("Enter a floating point number: ");
                    Console.WriteLine("Reverse: " + RecurseReverse(Double.Parse(Console.ReadLine())));

                    Console.Write("Enter a floating point string: ");
                    Console.WriteLine("Reverse: " + ReverseStringDouble(Console.ReadLine()));

                    break;
                default:
                    Console.WriteLine("Incorect value!");
                    break;
            }
            Console.Write("\nEnter the size of the array: ");
            int size = Int32.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Ehter the element " + "[" + (i + 1) + "]: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Your Array: ");
            Output(arr);

            ReverseArray(ref arr);

            Console.Write("Revers Array: ");
            Output(arr);

            int[] newArr;
            ReverseArrayOut(arr, out newArr);
            Console.Write("Revers NewArray: ");
            Output(arr);

            Console.ReadKey();
        }

        //1 (1234->4321)
        static int Reverse(int value)
        {
            int reverse_number = 0;
            while (value > 0)
            {
                int remainder = value % 10;
                reverse_number = (reverse_number * 10) + remainder;
                value = value / 10;
            }

            return reverse_number;
        }
        static void RecurseReverse(int value)
        {
            int reverse_number = value % 10;
            if (value == 0)
                return;
            Console.Write(reverse_number);
            Reverse(value/10);
        }
        static int RecurseReverse(int value, int reverse_number = 0)
        {
            if (value == 0) return reverse_number;

            int remainded = value % 10;
            reverse_number = (reverse_number * 10) + remainded;

            return RecurseReverse(value / 10, reverse_number);
        }

        //2 (АБВ->ВБА)
        static string Reverse(string value)
        {
            string reverse_string = string.Empty;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                reverse_string += value[i];
            }
            return reverse_string;
        }

        static string RecurseReverse(string value)
        {
            if (value.Length == 0) return value;

            return value[value.Length - 1] + RecurseReverse(value.Substring(0, value.Length - 1));
        }

        //3 (123.456->321.654)
        static double Reverse(double value)
        {
            return Double.Parse(ReverseStringDouble(value.ToString()));
        }
        static double RecurseReverse(double value)
        {
            return Double.Parse(RecurseReverseStringDouble(value.ToString()));
        }
        //4 (АБВ,ГДЕ->ВБА,ЕДГ)
        static string ReverseStringDouble(string value)
        {
            string reverse_string = string.Empty;
            var string_arr = value.Split(',');

            reverse_string += Reverse(string_arr[0]);
            reverse_string += ",";
            reverse_string += Reverse(string_arr[1]);

            return reverse_string;
        }

        static string RecurseReverseStringDouble(string value)
        {
            string reverse_string = string.Empty;
            var string_arr = value.Split(',');

            reverse_string += RecurseReverse(string_arr[0]);
            reverse_string += ",";
            reverse_string += RecurseReverse(string_arr[1]);

            return reverse_string;
        }

        //Реалізувати метод, що буде масив повертати задом навпаки + Виконати пункт 7 з використанням ключових слів ref i out

        static void ReverseArray(ref int[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
        static void ReverseArrayOut(int[] array, out int[] newArray)
        {
            newArray = array;
            for (int i = 0; i < newArray.Length / 2; i++)
            {
                int temp = newArray[i];
                newArray[i] = newArray[newArray.Length - i - 1];
                newArray[newArray.Length - i - 1] = temp;
            }
        }

        //Вивід масиву
        static void Output(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\t" + array[i]);
            }
            Console.WriteLine();
        }
    }
}