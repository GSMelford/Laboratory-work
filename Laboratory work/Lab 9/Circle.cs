using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Circle : Shape
    {
        public override string ShapeName { get; protected set; }
        public override ConsoleColor ShapeColor { get; set; }
        public override int NumberVertices => 0;
        private int Radius { get; set; }
        public Circle(string shapeName)
        {
            Random random = new Random();
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)(new Random().Next(16));
            Radius = random.Next(100);
        }
        public Circle(string shapeName, int sideLength)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)(new Random().Next(16));
            Radius = sideLength;
        }
        public Circle(string shapeName, int sideLength, int сolor)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)сolor;
            Radius = sideLength;
        }
        public override double GetPerimeter() => Math.PI * (Radius ^ 2);
        public override double GetSquare() => 2 * Math.PI * Radius;
        public void Draw()
        {
            Console.ForegroundColor = ShapeColor;
            if (ShapeColor == ConsoleColor.Black)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Фигура Круг.\nНазвание фигуры: {ShapeName};\nКоличество вершин: {NumberVertices};" +
                $"\nРадиус: {Radius};\nПериметер: {GetPerimeter()};\nПлоща: {GetSquare()};");
            Console.ResetColor();
        }
    }
}
