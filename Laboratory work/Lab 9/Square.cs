using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Square : Shape, IDraw
    {
        public override string ShapeName { get; protected set; }
        public override string Color { get; set; }
        public override int NumberVertices => 4;
        private int SideLength { get; set; }
        public Square(string shapeName)
        {
            ShapeName = shapeName;
            Color = String.Format("#{0:X6}", new Random().Next(0x1000000));
            SideLength = new Random().Next(100);
        }
        public Square(string shapeName, int sideLength)
        {
            ShapeName = shapeName;
            Color = String.Format("#{0:X6}", new Random().Next(0x1000000));
            SideLength = sideLength;
        }
        public Square(string shapeName, int sideLength, string сolor)
        {
            ShapeName = shapeName;
            Color = сolor;
            SideLength = sideLength;
        }
        public override double GetPerimeter() => SideLength * 4;
        public override double GetSquare() => SideLength ^ 2;
        public void Draw()
        {
            
        }
    }
}
