using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Independent_work_1
{
    class Headphones
    {
        public List<string> Colors = new List<string>();
        public int Year;
        public int Price;
        public string Brand;
        public void InputInfo()
        {
            Console.WriteLine("Введите информацию про наушники. \n");
            
            int numberColors = 0;
            while(true)
            {
                Console.Write("Количество цветов наушников: ");
                if (!int.TryParse(Console.ReadLine(), out numberColors) || numberColors < 0)
                    Console.WriteLine("Вы ввели неправльное значение, попробуйте ещё раз.");
                else
                    break;
            }

            for (int i = 0; i < numberColors; i++)
            {
                Console.Write($"Цвет {i}: ");
                Colors.Add(Console.ReadLine());
            }

            while (true)
            {
                Console.Write("Год выпуска: ");
                if (!int.TryParse(Console.ReadLine(), out Year) || Year < 1910)
                    Console.WriteLine("Вы ввели неправльное значение, попробуйте ещё раз.");
                else
                    break;
            }

            while (true)
            {
                Console.Write("Цена: ");
                if (!int.TryParse(Console.ReadLine(), out Price) || Price < 1)
                    Console.WriteLine("Вы ввели неправльное значение, попробуйте ещё раз.");
                else
                    break;
            }

            Console.Write("Брэнд: ");
            Brand = Console.ReadLine();
        }
        public void InputInfoFind()
        {
            Console.WriteLine("Введите информацию про наушники (если вы не помните её нажимите просто 'Enter'): ");
            Console.Write("Введите цвет наушников, который Вы бы хотели: ");
            Colors.Add(Console.ReadLine());

            while (true)
            {
                Console.Write("Год выпуска: ");
                string temp = Console.ReadLine();
                if (temp != string.Empty)
                {
                    if (!int.TryParse(temp, out Year) || Year < 1910)
                        Console.WriteLine("Вы ввели неправльное значение, попробуйте ещё раз.");
                    else
                        break;
                }
                else
                {
                    Year = 0;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Цена: ");
                string temp = Console.ReadLine();
                if (temp != string.Empty)
                {
                    if (!int.TryParse(temp, out Price) || Price < 1)
                        Console.WriteLine("Вы ввели неправльное значение, попробуйте ещё раз.");
                    else
                        break;
                }
                else
                {
                    Price = 0;
                    break;
                }
            }

            Console.Write("Брэнд: ");
            Brand = Console.ReadLine();
        }
        public override string ToString()
        {
            string headphonesInfo = $"\nИнформация про наушники:\nЦвета: ";
            foreach (var color in Colors)
            {
                headphonesInfo += color + " ";
            }
            headphonesInfo += $"\nГод выпуска: {Year}\nЦена: {Price}\nБрэнд: {Brand}\n";

            return headphonesInfo;
        }
    }
}
