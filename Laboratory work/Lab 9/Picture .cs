using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Picture
    {
        enum ShapeName { square = 1, circle, triangle}
        private List<Shape> shapes;
        public Picture() { shapes = new List<Shape>(); }
        public Picture(int colectionsSize) { shapes = new List<Shape>(colectionsSize); }
        public void AddShape(Shape shape) { shapes.Add(shape); }
        public bool RemoveShape(string shapeName, int typeShape, double square)
        {
            bool found;
            foreach (var shape in shapes)
            {
                if(typeShape == square)
                    if (shape is Square)
                        found = true;
            }
        }
    }
}
