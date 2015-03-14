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
