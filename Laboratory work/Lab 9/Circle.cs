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
            ShapeColor = (ConsoleColor)random.Next(16);
            Radius = random.Next(100);
        }
        public Circle(string shapeName, int sideLength)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)(new Random().Next(16));
            Radius = sideLength;
        }
        public Circle(string shapeName, int sideLength, int color)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)color;
            Radius = sideLength;
        }
        public override double GetPerimeter() => Math.PI * (Radius * Radius);
        public override double GetSquare() => 2 * Math.PI * Radius;
        public override void Draw()
        {
            Console.ForegroundColor = ShapeColor;
            if (ShapeColor == ConsoleColor.Black)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"\nФигура Круг.\nНазвание фигуры: {ShapeName};\nКоличество вершин: {NumberVertices};" +
                $"\nРадиус: {Radius};\nПериметер: {GetPerimeter()};\nПлоща: {GetSquare()}\nЦвет: {ShapeColor};");
            Console.ResetColor();
        }
    }
}
