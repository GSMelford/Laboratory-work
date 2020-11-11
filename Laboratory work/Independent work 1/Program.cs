using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Independent_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HeadphonesCollection headphonesCollection = new HeadphonesCollection();
            Console.WriteLine("Добро пожаловать в магазин наушников!");

            for (int i = 0; i < 5; i++)
            {
                Headphones headphones = new Headphones();
                headphones.InputInfo();
                headphonesCollection.AddHeadphones(headphones);
            }

            /*Headphones headphones1 = new Headphones { Colors = { "Red", "Green" }, Brand = "X", Price = 1573, Year = 1960 };
            Headphones headphones2 = new Headphones { Colors = {"Black", "Red", "Green" }, Brand = "Y", Price = 1573, Year = 2020 };
            headphonesCollection.AddHeadphones(headphones1);
            headphonesCollection.AddHeadphones(headphones2);*/

            bool workShop = true;
            while(workShop)
            {
                Console.WriteLine("\nМеню магазина: \n[1] Найти наушники \n[2] Вывести все наушники \n[0] Выйти ");
                int select;
                while (true)
                {
                    Console.Write("Ваш выбор: ");
                    if (!int.TryParse(Console.ReadLine(), out select) || select > 0 || select < 2)
                        break;
                    else
                        Console.WriteLine("Вы ввели неправльное значение, попробуйте ещё раз.");
                }
                switch (select)
                {
                    case 0:
                        workShop = false;
                        break;
                    case 1:
                        Headphones headphonesFind = new Headphones();
                        headphonesFind.InputInfoFind();
                        headphonesCollection.PrintInfoHeadphones(headphonesCollection.FindHeadphones(headphonesFind));
                        
                        break;
                    case 2:
                        headphonesCollection.PrintInfoHeadphones();
                        break;
                    default:
                        break; 
                }
            }
            

        }
    }
}
