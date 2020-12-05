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
        public override string Color { get; set; }
        public override int NumberVertices => 3;
        private int RibLength { get; set; }
        private int BaseLength { get; set; }
        public Triangle(string shapeName)
        {
            Random random = new Random();
            ShapeName = shapeName;
            Color = String.Format("#{0:X6}", random.Next(0x1000000));
            RibLength = random.Next(100);
            BaseLength = random.Next(RibLength*2);
        }
        public Triangle(string shapeName, int ribLength, int baseLength)
        {
            ShapeName = shapeName;
            Color = String.Format("#{0:X6}", new Random().Next(0x1000000));
            RibLength = ribLength;
            BaseLength = baseLength;
        }
        public Triangle(string shapeName, int ribLength, int baseLength, string color)
        {
            ShapeName = shapeName;
            Color = color;
            RibLength = ribLength;
            BaseLength = baseLength;
        }
        public override double GetPerimeter() => BaseLength + RibLength ^ 2;
        public override double GetSquare() => 0.25 * BaseLength * Math.Sqrt(4 * RibLength ^ 2 - BaseLength ^ 2);
    }
}
