using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    class Rectangle:Figure
    {
        public Rectangle(double x, double y, string name): base (x, y, name)
        {
            X = x;
            Y = y;
            Name = name;
        }
        public override double Area(double length, double breadth)
        {
            return length * breadth;
        }       
    }
}
