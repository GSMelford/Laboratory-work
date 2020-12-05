using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    abstract class Shape
    {
        abstract public string ShapeName { get;}
        abstract public string Color { get; set; }
        abstract public int NumberVertices { get; }
        abstract public int Perimeter();
        abstract public int Square();
    }
}