using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public bool RemoveShape(Shape shape)
        {
            if (shape is Square)
            {
                shapes.RemoveAll(s => s is Square && s.ShapeName == shape.ShapeName && s.GetSquare() > shape.GetSquare());
                return true;
            }
            else if (shape is Circle)
            {
                shapes.RemoveAll(s => s is Circle && s.ShapeName == shape.ShapeName && s.GetSquare() > shape.GetSquare());
                return true;
            }
            else if (shape is Triangle)
            {
                shapes.RemoveAll(s => s is Triangle && s.ShapeName == shape.ShapeName && s.GetSquare() > shape.GetSquare());
                return true;
            }
            return false;
        }
        public Shape GetShape(int index) => shapes.ElementAtOrDefault<Shape>(index);
        public void Draw()
        {
            foreach (var shape in shapes)
                shape.Draw();
        }
    }
}