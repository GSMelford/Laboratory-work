using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> MyList = new List<object>();

            int number;

            while (true)
            {
                Console.Write("Введите количество обьектов в листе: ");
                if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
                    Console.WriteLine("Вы ввели недопустимое число! Попробуйте ещё раз.");
                else
                    break;
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Введите значение {i + 1}: ");
                string value = Console.ReadLine();

                if (int.TryParse(value, out int intTemp))
                {
                    Console.WriteLine("This is int");
                    MyList.Add(intTemp);
                }
                else if (char.TryParse(value, out char charTemp))
                {
                    Console.WriteLine("This is char");
                    MyList.Add(charTemp);
                }
                else if (double.TryParse(value, out double doubleTemp))
                {
                    Console.WriteLine("This is double");
                    MyList.Add(doubleTemp);
                }
                else if (bool.TryParse(value, out bool boolTemp))
                {
                    Console.WriteLine("This is bool");
                    MyList.Add(boolTemp);
                }
                else
                {
                    Console.WriteLine("This is string");
                    MyList.Add(value);
                }
            }

            int char_counter = 0;
            int string_counter = 0;
            int int_counter = 0;
            int double_counter = 0;
            int bool_counter = 0;

            for (int i = 0; i < number; i++)
            {
                if (MyList[i] is int intTemp)
                    int_counter++;
                else if (MyList[i] is char charTemp)
                    char_counter++;
                else if (MyList[i] is double doubleTemp)
                    double_counter++;
                else if (MyList[i] is bool boolTemp)
                    bool_counter++;
                else if (MyList[i] is string stringTemp)
                    string_counter++;
            }

            Console.WriteLine("\nРезультат работы:");
            Console.WriteLine($"Таких типов как int: {int_counter}");
            Console.WriteLine($"Таких типов как char: {char_counter}");
            Console.WriteLine($"Таких типов как double: {double_counter}");
            Console.WriteLine($"Таких типов как bool: {bool_counter}");
            Console.WriteLine($"Таких типов как string: {string_counter}");

            Console.ReadKey();
        }
    }
}
