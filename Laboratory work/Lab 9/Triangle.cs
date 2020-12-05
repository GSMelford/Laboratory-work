using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Triangle : Shape
    {
        public override string ShapeName { get; protected set; }
        public override ConsoleColor ShapeColor { get; set; }
        public override int NumberVertices => 3;
        private int RibLength { get; set; }
        private int BaseLength { get; set; }
        public Triangle(string shapeName)
        {
            Random random = new Random();
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)(new Random().Next(16));
            RibLength = random.Next(100);
            BaseLength = random.Next(RibLength*2);
        }
        public Triangle(string shapeName, int ribLength, int baseLength)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)(new Random().Next(16));
            RibLength = ribLength;
            BaseLength = baseLength;
        }
        public Triangle(string shapeName, int ribLength, int baseLength, int color)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)color;
            RibLength = ribLength;
            BaseLength = baseLength;
        }
        public override double GetPerimeter() => BaseLength + RibLength ^ 2;
        public override double GetSquare() => 0.25 * BaseLength * Math.Sqrt(4 * RibLength ^ 2 - BaseLength ^ 2);
        public void Draw()
        {
            Console.ForegroundColor = ShapeColor;
            if (ShapeColor == ConsoleColor.Black)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Фигура Триугольник.\nНазвание фигуры: {ShapeName};\nКоличество вершин: {NumberVertices};" +
                $"\nБоковая сторона: {RibLength};\nОснование: {RibLength};\nПериметер: {GetPerimeter()};\nПлоща: {GetSquare()};");
            Console.ResetColor();
        }
    }
}
