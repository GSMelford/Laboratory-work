using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.1 Нажимите любую клавишу чтобы продолжить...");
            Console.ReadKey();

            Square shape1 = new Square("Square 1");
            shape1.Draw();
            Square shape2 = new Square("Square 2", 10);
            shape2.Draw();
            Square shape3 = new Square("Square 3",23,5);
            shape3.Draw();
            Thread.Sleep(100);

            Circle circle1 = new Circle("Circle 1");
            circle1.Draw();
            Circle circle2 = new Circle("Circle 2",10);
            circle2.Draw();
            Circle circle3 = new Circle("Circle 3",5,4);
            circle3.Draw();
            Thread.Sleep(100);

            Triangle triangle1 = new Triangle("Triangle 1");
            triangle1.Draw();
            Triangle triangle2 = new Triangle("Triangle 2",10,8);
            triangle2.Draw();
            Triangle triangle3 = new Triangle("Triangle 3",10,8,10);
            triangle3.Draw();
            Thread.Sleep(100);

            Console.WriteLine("\nЗадание 1.2 Нажимите любую клавишу чтобы продолжить...");
            Console.ReadKey();

            Console.Write("Сколько фигур сгенерировать? Введите цифру от 5 до 20: ");
            int size = CorrectInputIntRange(5,20);

            Picture picture = new Picture(size);
            Random random = new Random();

            for (int i = 0; i < picture.ShapeCount; i++)
            {
                Thread.Sleep(100);
                int type = random.Next(3);
                Shape shape = null;

                if (type == 0)
                    shape = new Square($"Square {i}");
                else if (type == 1)
                    shape = new Circle($"Circle {i}");
                else if (type == 2)
                    shape = new Triangle($"Triangle {i}");

                picture.AddShape(shape);
                Console.WriteLine($"Created {100 / picture.ShapeCount * (i + 1)}%");
            }
            Console.WriteLine($"В массиве {picture.ShapeCount} элементов.");
            Console.WriteLine("Обращение к элементу листа через индексатор. Нажимите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.WriteLine(picture[size - 3].ShapeName);
            Console.WriteLine(picture[size - 2].ShapeName);
            Console.WriteLine(picture[size - 1].ShapeName);

            Console.WriteLine("\nЗадание 1.3.");
            Console.WriteLine("\nВывод информации про фигуры с помощью Picture и метода Draw. \nНажимите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            picture.Draw();

            Console.WriteLine("\nУдаление фигур... Нажимите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            if (picture.RemoveShape(picture[size - 1].ShapeName, 1, 99999))
                Console.WriteLine($"Фигура под именем {picture[size - 1].ShapeName} была удалена.");
            else if (picture.RemoveShape(picture[size - 1].ShapeName, 2, 99999))
                Console.WriteLine($"Фигура под именем {picture[size - 1].ShapeName} была удалена.");
            else if (picture.RemoveShape(picture[size - 1].ShapeName, 3, 99999))
                Console.WriteLine($"Фигура под именем {picture[size - 1].ShapeName} была удалена.");

            Console.WriteLine("\nВывод информации про фигуры с помощью класса Painter. \nНажимите любую клавишу чтобы продолжить...");
            Console.ReadKey();

            Painter.Draw(picture[size - 3]);
            Painter.Draw(circle3);

            Console.ReadKey();
        }
        public static int CorrectInputIntRange(int min, int max)
        {
            int number;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
                    Console.WriteLine($"Invalid value. Check that it is in the range from {min} to {max}.");
                else
                    return number;
            }
        }
    }
} 
