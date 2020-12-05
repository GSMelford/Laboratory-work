using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    abstract class Shape
    {
        abstract public string ShapeName { get; protected set; }
        abstract public ConsoleColor ShapeColor { get; set; }
        abstract public int NumberVertices { get;}
        abstract public double GetPerimeter();
        abstract public double GetSquare();
    }
}