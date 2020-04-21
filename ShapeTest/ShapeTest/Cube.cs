using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    class Cube:Figure
    {
        public Cube(double x, double y, string name) : base(x, y, name)
        {
            X = x;
            Y = y;
            Name = name;
        }
        public override double Area(double length, double breadth)
        {
            return 6 * (Math.Pow(length, 2));
        }
    }
}
