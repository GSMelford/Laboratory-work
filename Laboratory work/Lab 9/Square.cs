﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_9
{
    class Square : Shape, IDraw
    {
        public override string ShapeName { get; protected set; }
        public override ConsoleColor ShapeColor { get; set; }
        public override int NumberVertices => 4;
        private int SideLength { get; set; }
        public Square(string shapeName)
        {
            Random random = new Random();
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)random.Next(16);
            SideLength = random.Next(100);
        }
        public Square(string shapeName, int sideLength)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)(new Random().Next(16));
            SideLength = sideLength;
        }
        public Square(string shapeName, int sideLength, int сolor)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)сolor;
            SideLength = sideLength;
        }
        public override double GetPerimeter() => SideLength * 4;
        public override double GetSquare() => SideLength ^ 2;
        public void Draw()
        {
            Console.ForegroundColor = ShapeColor;
            if (ShapeColor == ConsoleColor.Black)
                Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Фигура Квадрат.\n Название фигуры: {ShapeName};\n Количество вершин: {NumberVertices};" +
                $"\n Длина стороны: {SideLength};\n Периметер: {GetPerimeter()};\n Площа: {GetSquare()};");
        }
    }
}
