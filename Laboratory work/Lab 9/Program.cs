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
            /*Console.WriteLine("Добро пожаловать! Лабораторная работа №9");
            while(true)
            {
                Console.WriteLine("Меню:\n" +
                "[1] Добавить фигуру в колекцию\n" +
                "[2] Удалить фигуру с колекции\n" +
                "[3] Посмотреть все фигуры колекции\n" +
                "[0] Выйти с программы\n");

                int choice = CorrectInputIntRange(0, 3);
                switch (choice)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("An error has occurred.");
                        break;
                }
            }*/


            /*Random random1 = new Random();
            Picture picture = new Picture();
            int NumberShape = 20;
            for (int i = 0; i < NumberShape; i++)
            {
                Thread.Sleep(100);
                int f = random1.Next(3);
                if (f == 0)
                {
                    Square ff = new Square($"Name{i}");
                    picture.AddShape(ff);
                }
                else if (f == 1)
                {
                    Circle ff = new Circle($"Name{i}");
                    picture.AddShape(ff);
                }
                else if(f == 2)
                {
                    Triangle ff = new Triangle($"Name{i}");
                    picture.AddShape(ff);
                    
                }
                Console.WriteLine($"Loading {100 / NumberShape * (i + 1)}%");
            }
            picture.Draw();
            Console.ReadKey();*/
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
