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
            SheikhGarage sheikhGarage = new SheikhGarage();
            
            Console.WriteLine("Добро пожаловать в гараж Шейха!");

            bool onGarage = true;
            while(onGarage)
            {
                Console.WriteLine("\nЧто будем делать?");
                Console.WriteLine("\nКупим новую машину (1); \nПокатаемся на машине (2); \nВыкинем машину (3); \nВыйдем с гаража (0)");
                Console.Write("Ваш выбор: ");
                int select = Int32.Parse(Console.ReadLine());

                switch (select)
                {
                    case 0:
                        onGarage = false;
                        break;
                    case 1:

                        Console.WriteLine("\nКакую машину купим?");
                        Car carAdd = new Car();
                        carAdd.EnterCarParam();
                        sheikhGarage.garage.Add(carAdd);

                        break;
                    case 2:

                        Console.WriteLine("\nНа какой машине будем кататься?");
                        Car carFind = new Car();
                        carFind.EnterCarParamForFind();
                        sheikhGarage.PrintInfoCar(sheikhGarage.FindCar(carFind));

                        /*Console.Write("На какой машине поедем? Ввидете номер: ");
                        int number = Int32.Parse(Console.ReadLine());
                        carFind.RideACar(number);*/

                        break;
                    case 3:

                        Console.WriteLine("\nНа какой машине будем кататься?");
                        Car carRemove = new Car();
                        carRemove.EnterCarParamForFind();
                        sheikhGarage.RemoveCar(sheikhGarage.FindCar(carRemove));
                        break;
                    default:
                        Console.WriteLine("Вы ввели не правильное значение, попробуйте ещё раз!");
                        break;
                }
            }
        }
    }
}
