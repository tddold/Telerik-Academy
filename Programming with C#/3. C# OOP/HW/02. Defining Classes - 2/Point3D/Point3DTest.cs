﻿namespace Point3D
{
    using System;

    public class Point3DTest
    {
        static void Main()
        {
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

            Console.WriteLine("Distance --> {0:F2}",Distance.CalculateDistance(startPoint, endPoint));
            PrintSeparateLine();

        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
