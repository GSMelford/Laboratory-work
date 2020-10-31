using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class SheikhGarage
    {
        public List<Car> garage = new List<Car>();
        private List<int> carFinded = new List<int>();
        public List<int> FindCar(Car car)
        {
            carFinded.Clear();

            for (int i = 0; i < garage.Count; i++)
            {
                if (car.car_name != "-")
                {
                    if (garage[i].car_name != car.car_name)
                        continue;
                }

                if(car.car_color != "-")
                {
                    if (garage[i].car_color != car.car_color)
                        continue;
                }

                if (car.car_speed != -1)
                {
                    if (garage[i].car_speed != car.car_speed)
                        continue;
                }

                if (car.car_year != -1)
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
                Console.WriteLine("Такой машины нету.");
                return;
            }
            foreach (var car in carFinded)
            {
                Console.WriteLine($"\nМашина №{car+1}: ");
                Console.WriteLine($"\nИмя машины: {garage[car].car_name} ");
                Console.WriteLine($"Цвет машины: {garage[car].car_color} ");
                Console.WriteLine($"Скорость машины: {garage[car].car_speed} ");
                Console.WriteLine($"Год выпуска машины: {garage[car].car_year} ");
            }
        }

        public void RemoveCar(List<int> carFinded)
        {
            if (carFinded.Count == 0)
            {
                Console.WriteLine("Такой машины нету.");
                return;
            }

            foreach (var car in carFinded)
            {
                garage.RemoveAt(car);
                Console.WriteLine($"Машина №{car+1} была выкинута(");
            }
        }
    }
}
