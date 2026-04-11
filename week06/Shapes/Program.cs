using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // You know, the cool thing here is that this list can hold ANY shape.
        List<Shape> shapes = new List<Shape>();

        // Adding our different shapes to the same list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 10));
        shapes.Add(new Circle("Green", 3));

        Console.WriteLine("Shape Areas and Colors:");
        Console.WriteLine("-----------------------");

        foreach (Shape s in shapes)
        {
            // This is polymorphism! The program knows which 'GetArea' to call
            // even though 's' is just treated as a generic Shape here.
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}