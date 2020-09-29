using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratory work No. 4");
            Console.Write("Enter the size array: ");
            int size = Int32.Parse(Console.ReadLine());
            Random rand = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Ehter the element " + "[" + (i + 1) + "]: ");
                array[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray: ");
            Output(array);

            bool series_num = false;
            Console.WriteLine("\nExpand (0) or shrink (1) an array?");
            Console.Write("Your choice: ");
            int select = Int32.Parse(Console.ReadLine());

            switch (select)
            {
                case 0:
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] == array[i + 1])
                            series_num = true;
                        if (array[i] != array[i + 1] && series_num)
                        {
                            series_num = false;
                            array = ExpandArray(array, i);
                        }
                    }
                    if (series_num)
                        array = ExpandArray(array, array.Length - 1);
                    Console.WriteLine("\nReworked array: ");
                    Output(array);
                    break;
                case 1:
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] == array[i + 1])
                            series_num = true;
                        if (array[i] != array[i + 1] && series_num)
                        {
                            series_num = false;
                            array = ReduceArray(array, i);
                            i--;
                        }
                    }
                    if (series_num)
                        array = ReduceArray(array, array.Length - 1);
                    Console.WriteLine("\nReworked array: ");
                    Output(array);
                    break;
                default:
                    Console.WriteLine("Incorrect value!");
                    break;
            }
        }

        static int[] ReduceArray(int[] array, int index)
        {
            if (array == null) return null;
            int[] temp = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                temp[i] = array[i];
            }

            for (int i = index; i < temp.Length; i++)
            {
                temp[i] = array[i + 1];
            }
            return temp;
        }
        static int[] ExpandArray(int[] array, int index)
        {
            if (array == null) return null;
            int[] temp = new int[array.Length + 1];

            for (int i = 0; i <= index; i++)
            {
                temp[i] = array[i];
            }

            for (int i = index + 1; i < temp.Length; i++)
            {
                temp[i] = array[i - 1];
            }

            return temp;
        }

        static void Output(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
