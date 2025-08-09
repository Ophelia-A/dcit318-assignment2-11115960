using System;

namespace Task2_AbstractClasses
{
    // Abstract base class
    abstract class Shape
    {
        // Abstract method (no body here)
        public abstract double GetArea();
    }

    // Derived class Circle
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

    // Derived class Rectangle
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

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Circle with radius 5
            Circle circle = new Circle(5);
            Console.WriteLine($"Circle area: {circle.GetArea()}");

            // Create a Rectangle with width 6 and height 6
            Rectangle rectangle = new Rectangle(6, 6);
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");

            Console.ReadLine();
        }
    }
}
