using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Circle : Shape
    {
        private string _shapeName;
        private string _сolor;
        private int _numberVertices = 4;
        private int Radius { get; set; }
        public override string ShapeName => _shapeName;
        public override string Color { get { return _сolor; } set { Color = _сolor; } }
        public override int NumberVertices => _numberVertices;
        public Circle(string shapeName)
        {
            _shapeName = shapeName;
            _сolor = String.Format("#{0:X6}", new Random().Next(0x1000000));
            Radius = new Random().Next(100);
        }
        public Circle(string shapeName, int sideLength)
        {
            _shapeName = shapeName;
            _сolor = String.Format("#{0:X6}", new Random().Next(0x1000000));
            Radius = sideLength;
        }
        public Circle(string shapeName, int sideLength, string сolor)
        {
            _shapeName = shapeName;
            _сolor = сolor;
            Radius = sideLength;
        }
        public override double GetPerimeter() => Math.PI*(Radius^2);
        public override double GetSquare() => 2*Math.PI*Radius;
    }
}
