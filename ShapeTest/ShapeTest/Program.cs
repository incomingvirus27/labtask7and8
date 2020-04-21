using System;

namespace ShapeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program that calculates the area of different shapes");
            Console.WriteLine("....................................................");

            //instantiating the Objects
            Figure figures = new Figure(2.0, 4.0, "Luke");
            Triangle triangle = new Triangle(2.0, 4.0, "Luke");
            Cube cube = new Cube(2.0, 4.0, "Luke");
            Rectangle rectangle = new Rectangle(2.0, 4.0, "Luke");
            Square squares = new Square(2.0, 4.0, "Luke");

            
            double length, width; //declaring the variables to be collected from the user.

            /*Console.Write("Please enter the name of the shape: ");
            string name = Console.ReadLine();
            figures.Name = name;
            */

            Console.Write("Please enter the length of the shape: ");
            length = double.Parse(Console.ReadLine());
            figures.X = length;

            Console.Write("Please enter the width or height of the shape: ");
            width = double.Parse(Console.ReadLine());
            figures.Y = width;

            Console.WriteLine($"The area of a rectangle is {rectangle}");
            Console.WriteLine($"The area of a triangle is {triangle}");
            Console.WriteLine($"The area of a cube is {cube}");
            Console.WriteLine($"The area of a square is {squares}");
            Console.ReadLine();


        }
    }
}
