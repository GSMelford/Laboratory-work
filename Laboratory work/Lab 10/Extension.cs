using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    public static class Extension
    {
        public static int IntReverse(this int value)
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
        public static string StringReverse(this string value)
        {
            string reverse_string = string.Empty;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                reverse_string += value[i];
            }
            return reverse_string;
        }
        public static string StringDoubleReverse(this string value)
        {
            string reverse_string = string.Empty;
            var string_arr = value.Split('.');

            reverse_string += string_arr[0].StringReverse();
            reverse_string += ".";
            reverse_string += string_arr[1].StringReverse();

            return reverse_string;
        }
        public static double DoubleReverse(this double value) => Double.Parse(value.ToString().StringDoubleReverse());
        public static int[] ArrayReverse(this int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            return array;
        }
        public static int[] ArraySort(this int[] array)
        {
            Array.Sort(array);
            return array;
        }
    }
}