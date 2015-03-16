/*Problem 1. Structure
 *  Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
 *  Implement the ToString() to enable printing a 3D point.
 * 
 * Problem 2. Static read-only field
 *  Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
 *  Add a static property to return the point O.
 *  
 * Problem 3. Static class
 *  Write a static class with a static method to calculate the distance between two points in the 3D space.
 *  
 * Problem 4. Path
 *  Create a class Path to hold a sequence of points in the 3D space.
 *  Create a static class PathStorage with static methods to save and load paths from a text file.
 *  Use a file format of your choice.*/

namespace Point3D
{
    using System;

    public class Point3DTest
    {
        public static void Main()
        {
            Console.WriteLine("Structure Point3D");
            PrintSeparateLine();

            Point3D startPoint = new Point3D();

            Point3D endPoint = new Point3D();
            endPoint.X = 1;
            endPoint.Y = 2;
            endPoint.Z = 3;

            Console.WriteLine("\nPrint coordinates of start point:\n");
            Console.WriteLine(startPoint);
            PrintSeparateLine();

            Console.WriteLine("\nPrint coordinates of end point:\n");
            Console.WriteLine(endPoint);
            PrintSeparateLine();

            Console.WriteLine("\nDistance --> {0:F2}", Distance.CalculateDistance(startPoint, endPoint));
            PrintSeparateLine();

            Path path = new Path();
            path.AddPoints(startPoint, endPoint);
            Console.Write("\nData sent to the file:    ");
            Console.WriteLine(path);

            PathStorage.SavePath(path, "output");
            Console.Write("Data taken from the file: ");
            Console.WriteLine(PathStorage.LoadFromFile("output"));
            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
