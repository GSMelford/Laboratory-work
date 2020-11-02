using System;
using System.Collections.Generic;
using System.Threading;

namespace Lab_8
{
    class SheikhGarage
    {
        static int number_car = 0;
        public List<Car> garage { get; } = new List<Car>();
        private List<int> carFinded = new List<int>();
        public void AddCar(Car car) => garage.Add(car);
        public List<int> FindCar(Car car)
        {
            carFinded.Clear();

            for (int i = 0; i < garage.Count; i++)
            {
                if (car.car_name != string.Empty)
                {
                    if (garage[i].car_name != car.car_name)
                        continue;
                }

                if(car.car_color != string.Empty)
                {
                    if (garage[i].car_color != car.car_color)
                        continue;
                }

                if (car.car_speed != 0)
                {
                    if (garage[i].car_speed != car.car_speed)
                        continue;
                }

                if (car.car_year != 0)
                {
                    if (garage[i].car_year != car.car_year)
                        continue;
                }
                carFinded.Add(i);
            }
            return carFinded;
        }
        public void PrintInfoCar(List<int> carFinded)
        {
            if(carFinded.Count == 0)
            {
                Console.WriteLine("Такой машины у Вас нету.");
                return;
            }
            foreach (var car in carFinded)
            {
                Console.WriteLine($"\n\tМашина №{car+1}: ");
                Console.WriteLine($"\nИмя машины: {garage[car].car_name} ");
                Console.WriteLine($"Цвет машины: {garage[car].car_color} ");
                Console.WriteLine($"Скорость машины: {garage[car].car_speed} ");
                Console.WriteLine($"Год выпуска машины: {garage[car].car_year} ");
            }
        }
        public void RemoveCar(int car_number)
        { 
            garage.RemoveAt(car_number);
            Console.WriteLine($"Машина №{car_number + 1} '{garage[car_number - 1].car_name}' была выкинута(");
        }
        public void RideACar(int car_number)
        {
            Console.WriteLine($"\nЕдем на машине №{car_number} : '{garage[car_number-1].car_name}' ");
            Thread.Sleep(2000);
            Console.WriteLine("Приехали.\n");
        }
    }
}