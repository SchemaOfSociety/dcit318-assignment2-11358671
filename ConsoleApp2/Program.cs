using System;

namespace AbstractClassDemo
{
    // Abstract base class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class - Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class - Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Shape myCircle = new Circle(5.0);       // Radius = 5
            Shape myRectangle = new Rectangle(4.0, 6.0); // Width = 4, Height = 6

            Console.WriteLine("Circle Area: " + myCircle.GetArea());
            Console.WriteLine("Rectangle Area: " + myRectangle.GetArea());

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}

