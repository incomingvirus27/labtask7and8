using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    class Figure
    {
        private double x;
        private double y;
        private string name;

        public Figure(double x, double y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public virtual double Area(double length, double breadth)
        {
            return length * breadth;
        }

        public override string ToString()
        {
            return $"is {Area(x, y)}";
        }
    }
}
