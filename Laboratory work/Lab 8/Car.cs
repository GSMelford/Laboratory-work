using System;

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
            while(true)
            {
                Console.Write("Введите её название: ");
                car_name = Console.ReadLine();
                if (car_name != string.Empty)
                    break;
                else
                    Console.WriteLine("Вы ничего не ввели. Поробуйте ещё раз.");
            }

            while (true)
            {
                Console.Write("Введите её цвет: ");
                car_color = Console.ReadLine();
                if (car_name != string.Empty)
                    break;
                else
                    Console.WriteLine("Вы ничего не ввели. Поробуйте ещё раз.");
            }

            while(true)
            {
                Console.Write("Введите её скорость: ");
                if (!int.TryParse(Console.ReadLine(), out car_speed) || car_speed < 1)
                    Console.WriteLine("\nВы ввели не корректную скорость. Попробуйте ещё раз.\n");
                else
                    break;
            }

            while (true)
            {
                Console.Write("Введите её год выпуска: ");
                if (!int.TryParse(Console.ReadLine(), out car_year) || car_year < 1886)
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
                if (value != string.Empty)
                {
                    if (!int.TryParse(value, out car_speed) || car_speed < 1)
                        Console.WriteLine("\nВы ввели не корректную скорость. Попробуйте ещё раз.\n");
                    else
                        break;
                }
                else
                {
                    car_speed = 0;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Введите её год выпуска: ");
                string value = Console.ReadLine();
                if (value != string.Empty)
                {
                    if (!int.TryParse(value, out car_year) || car_year < 1886)
                        Console.WriteLine("\nВы ввели не корректный год выпуска. Попробуйте ещё раз.\n");
                    else
                        break;
                }
                else
                {
                    car_year = 0;
                    break;
                }
            }
        }
    }
}
