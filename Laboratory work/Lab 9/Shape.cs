using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    abstract class Shape : IDraw
    {
        public abstract string ShapeName { get; protected set; }
        public abstract ConsoleColor ShapeColor { get; set; }
        public abstract int NumberVertices { get;}
        public abstract double GetPerimeter();
        public abstract double GetSquare();
        public abstract void Draw();
    }
}