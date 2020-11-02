using System;
using System.Collections.Generic;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            SheikhGarage sheikhGarage = new SheikhGarage();
            List<int> carFinded = new List<int>();
            Console.WriteLine("Добро пожаловать в гараж Шейха!");

            bool onGarage = true;
            while(onGarage)
            {
                Car car = new Car();
                Console.WriteLine($"\nЧто будем делать? Сейчас у Вас {sheikhGarage.garage.Count} машин.");
                Console.WriteLine("\n[1] Купим новую машину. \n[2] Покатаемся на машине. \n[3] Выкинем машину. \n[4] Список всех машин. \n[0] Выйдем с гаража.");
                int select = InputCheckRangeInt(4);

                if(select == 0)
                    onGarage = false;
                else if(select == 1)
                {
                    Console.WriteLine("\nКакую машину купим?");
                    car.EnterCarParam();
                    sheikhGarage.AddCar(car);
                }
                else if(select == 2)
                {
                    Console.WriteLine("\nНа какой машине будем кататься? Если Вы не помните параметр, нажмите Enter.");
                    car.EnterCarParamForFind();
                    carFinded = sheikhGarage.FindCar(car);
                    sheikhGarage.PrintInfoCar(carFinded);

                    int car_number = 0;
                    bool correct_input = false;
                    if (carFinded.Count != 0)
                    {
                        while (!correct_input)
                        {
                            car_number = InputCheckRangeInt(sheikhGarage.garage.Count);
                            foreach (var car_index in carFinded)
                            {
                                if (car_number - 1 == car_index)
                                {
                                    correct_input = true;
                                    break;
                                }
                            }
                            if (!correct_input)
                                Console.WriteLine("Такой машины в поиске нету. Попробуйте ещё раз.\n");
                        }
                        sheikhGarage.RideACar(car_number);
                    }
                }
                else if(select == 3)
                {
                    Console.WriteLine("\nКакую машину выкинем? Если Вы не помните параметр, нажмите Enter.");

                    car.EnterCarParamForFind();
                    carFinded = sheikhGarage.FindCar(car);
                    sheikhGarage.PrintInfoCar(carFinded);

                    int car_number = 0;
                    bool correct_input = false;
                    if (carFinded.Count != 0)
                    {
                        while (!correct_input)
                        {
                            car_number = InputCheckRangeInt(sheikhGarage.garage.Count);
                            foreach (var car_index in carFinded)
                            {
                                if (car_number - 1 == car_index)
                                {
                                    correct_input = true;
                                    break;
                                }
                            }
                            if (!correct_input)
                                Console.WriteLine("Такой машины в поиске нету. Попробуйте ещё раз.\n");
                        }
                        sheikhGarage.RemoveCar(car_number-1);
                    }
                }
                else if (select == 4)
                {
                    if (sheikhGarage.garage.Count != 0)
                        sheikhGarage.PrintInfoCar(sheikhGarage.FindCar(new Car() { car_name = string.Empty, car_color = string.Empty, car_speed = 0, car_year = 0 }));
                    else
                        Console.WriteLine("У вас нету машин. Выберите пункт 1 чтобы купить её.");
                }
            }
        }
        static public int InputCheckRangeInt(int a)
        {
            int temp;
            while (true)
            {
                Console.Write("\nВаш выбор: ");
                if (!int.TryParse(Console.ReadLine(), out temp) || temp < 0 || temp > a)
                    Console.WriteLine("\nВы ввели неправильное значение. Попробуйте ещё раз.\n");
                else
                    break;
            }
            return temp;
        }
    }
}
