using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    class Square:Figure
    {
        public Square(double x, double y, string name) : base(x, y, name)
        {
            X = x;
            Y = y;
            Name = name;
        }
        public override double Area(double length, double width)
        {
            return Math.Pow(length, 2);
        }
    }
}
