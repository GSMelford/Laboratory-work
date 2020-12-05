using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Triangle : Shape
    {
        private string _shapeName;
        private string _сolor;
        private int _numberVertices = 4;
        private int RibLength { get; set; }
        private int BaseLength { get; set; }
        public override string ShapeName => _shapeName;
        public override string Color { get { return _сolor; } set { Color = _сolor; } }
        public override int NumberVertices => _numberVertices;
        public Triangle(string shapeName)
        {
            _shapeName = shapeName;
            _сolor = String.Format("#{0:X6}", new Random().Next(0x1000000));
            RibLength = new Random().Next(100);
            BaseLength = new Random().Next(RibLength*2);
        }
        public Triangle(string shapeName, int ribLength, int baseLength)
        {
            _shapeName = shapeName;
            _сolor = String.Format("#{0:X6}", new Random().Next(0x1000000));
            RibLength = ribLength;
            BaseLength = baseLength;
        }
        public Triangle(string shapeName, int ribLength, int baseLength, string color)
        {
            _shapeName = shapeName;
            _сolor = color;
            RibLength = ribLength;
            BaseLength = baseLength;
        }
        public override double GetPerimeter() => BaseLength + RibLength ^ 2;
        public override double GetSquare() => 0.25 * BaseLength * Math.Sqrt(4 * RibLength ^ 2 - BaseLength ^ 2);
    }
}
