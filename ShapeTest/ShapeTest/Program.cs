using System;

namespace ShapeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program that calculates the area of different shapes");
            Console.WriteLine("....................................................");
            
            double length, width; //declaring the variables to be collected from the user.

            Console.Write("Please enter the length of the shape: ");
            length = double.Parse(Console.ReadLine());            

            Console.Write("Please enter the width or height of the shape: ");
            width = double.Parse(Console.ReadLine());

            //instantiating the Objects
            Figure figures = new Figure(length, width, "Luke");
            Triangle triangle = new Triangle(length, width, "Luke");
            Cube cube = new Cube(length, width, "Luke");
            Rectangle rectangle = new Rectangle(length, width, "Luke");
            Square squares = new Square(length, width, "Luke");           

            Console.WriteLine($"The area of a rectangle is {rectangle}");
            Console.WriteLine($"The area of a triangle is {triangle}");
            Console.WriteLine($"The area of a cube is {cube}");
            Console.WriteLine($"The area of a square is {squares}");
            Console.ReadLine();


        }
    }
}
