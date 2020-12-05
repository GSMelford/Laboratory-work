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
        public override string Color { get; set; }
        public override int NumberVertices => 0;
        private int Radius { get; set; }
        public Circle(string shapeName)
        {
            ShapeName = shapeName;
            Color = String.Format("#{0:X6}", new Random().Next(0x1000000));
            Radius = new Random().Next(100);
        }
        public Circle(string shapeName, int sideLength)
        {
            ShapeName = shapeName;
            Color = String.Format("#{0:X6}", new Random().Next(0x1000000));
            Radius = sideLength;
        }
        public Circle(string shapeName, int sideLength, string сolor)
        {
            ShapeName = shapeName;
            Color = сolor;
            Radius = sideLength;
        }
        public override double GetPerimeter() => Math.PI * (Radius ^ 2);
        public override double GetSquare() => 2 * Math.PI * Radius;
    }
}
