using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_9
{
    class Picture: IDraw
    {
        private List<Shape> shapes;
        public int ShapeCount { get { return shapes.Count; } }
        public Picture() { shapes = new List<Shape>(); }
        public Picture(int colectionsSize) { shapes = new List<Shape>(colectionsSize); }
        public void AddShape(Shape shape) { shapes.Add(shape); }
        public bool RemoveShape(string name, int type, int square)
        {
            if (type == 1)
            {
                Console.WriteLine(shapes[0].GetSquare());
                shapes.RemoveAll(s => s is Square && s.ShapeName == name && s.GetSquare() < square);
                return true;
            }
            else if (type == 2)
            {
                shapes.RemoveAll(s => s is Circle && s.ShapeName == name && s.GetSquare() < square);
                return true;
            }
            else if (type == 3)
            {
                shapes.RemoveAll(s => s is Triangle && s.ShapeName == name && s.GetSquare() < square);
                return true;
            }
            return false;
        }
        public Shape this[int index] { get { return shapes[index]; } set { shapes[index] = value; } }
        public void Draw()
        {
            foreach (var shape in shapes)
                shape.Draw();
        }
    }
}