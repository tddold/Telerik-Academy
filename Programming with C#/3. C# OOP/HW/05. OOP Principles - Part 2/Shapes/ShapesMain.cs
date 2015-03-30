/*Problem 1. Shapes
 * Define abstract class Shape with only one abstract method CalculateSurface() and fields width and 
 * height.
 * Define two new classes Triangle and Rectangle that implement the virtual method and return the 
 * surface of the figure (height * width for rectangle and height * width/2 for triangle).
 * Define class Square and suitable constructor so that at initialization height must be kept equal to
 * width and implement the CalculateSurface() method.
 * Write a program that tests the behaviour of the CalculateSurface() method for different shapes 
 * (Square, Rectangle, Triangle) stored in an array.*/

namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ShapesMain
    {
        public static void Main()
        {
            Console.WriteLine("Problem 1. Shapes");
            PrintSeparateLine();

            // Array of shapes
            Shape[] shapes =
            {
                new Rectangle(2, 3),
                new Triangle(2, 3),
                new Square(2)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Surface of {0, -10} = {1:F2}", shape.GetType().Name, shape.CalculateSurface());
            }

            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
