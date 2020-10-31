using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_8
{
    class Car
    {
        public string car_name;
        public string car_color;
        public int car_speed;
        public int car_year;
       
        public void EnterCarParam()
        {
            Console.Write("Введите её название: ");
            car_name = Console.ReadLine();
            Console.Write("Введите её цвет: ");
            car_color = Console.ReadLine();
            
            while(true)
            {
                Console.Write("Введите её скорость: ");
                if (!int.TryParse(Console.ReadLine(), out car_speed) || car_speed < 0)
                    Console.WriteLine("\nВы ввели не корректную скорость. Попробуйте ещё раз.\n");
                else
                    break;
            }

            while (true)
            {
                Console.Write("Введите её год выпуска: ");
                if (!int.TryParse(Console.ReadLine(), out car_year) || car_year < 0)
                    Console.WriteLine("\nВы ввели не корректный год выпуска. Попробуйте ещё раз.\n");
                else
                    break;
            }
        }

        public void EnterCarParamForFind()
        {
            Console.Write("Введите её название: ");
            car_name = Console.ReadLine();
            Console.Write("Введите её цвет: ");
            car_color = Console.ReadLine();

            while (true)
            {
                Console.Write("Введите её скорость: ");
                string value = Console.ReadLine();
                if (value != "-")
                {
                    if (!int.TryParse(value, out car_speed) || car_speed < 0)
                        Console.WriteLine("\nВы ввели не корректную скорость. Попробуйте ещё раз.\n");
                    else
                        break;
                }
                else
                {
                    car_speed = -1;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Введите её год выпуска: ");
                string value = Console.ReadLine();
                if (value != "-")
                {
                    if (!int.TryParse(value, out car_year) || car_year < 1)
                        Console.WriteLine("\nВы ввели не корректный год выпуска. Попробуйте ещё раз.\n");
                    else
                        break;
                }
                else
                {
                    car_year = -1;
                    break;
                }
            }
        }

        /*public void RideACar(int car_number)
        {
            Console.WriteLine($"\nЕдем едем в соседнее село... на машине {car_number}");
            Thread.Sleep(2000);
            Console.WriteLine("Приехали.\n");
        }*/
    }
}
