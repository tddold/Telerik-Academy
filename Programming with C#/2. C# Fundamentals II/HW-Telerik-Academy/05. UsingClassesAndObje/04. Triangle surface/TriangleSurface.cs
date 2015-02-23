/*Problem 4. Triangle surface
Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
 */

namespace _04.Triangle_surface
{
    using System;
    class TriangleSurface
    {
        static void Main()
        {
            Console.Title = "Problem 4. Triangle surface";

            Console.WriteLine("Problem 4. Triangle surface!");
            PrintSeparateLine();

            Console.WriteLine("Enter what do you want (1, 2 or 3)\n");
            Console.WriteLine(" 1 : Side and Altitude");
            Console.WriteLine(" 2 : Three sides");
            Console.WriteLine(" 3 : Two sides and an angle between them");
            Console.Write("\nYour option : ");
            int choice = int.Parse(Console.ReadLine());
            PrintSeparateLine();

            if (choice == 1)
            {
                Console.Write("Enter Side : ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter the altitude : ");
                double altitude = double.Parse(Console.ReadLine());
                if (a <= 0 || altitude <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }                    

                Console.WriteLine("\nThe area is {0:F2}", AreaBySideAndAltitude(a, altitude));
            }
            else if (choice == 2)
            {
                Console.Write("Enter side 1 : ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter side 2 : ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter side 3 : ");
                double c = double.Parse(Console.ReadLine());

                if (a <= 0 || b <= 0 || c <= 0 || a + b < c || a + b < b || b + c < a)
                {
                    throw new ArgumentOutOfRangeException();
                }                    

                // I m going to use the Heron's formula to solve this
                Console.WriteLine("\nThe area is : {0:F2}", AreaByThreeSides(a, b, c));
            }
            else if (choice == 3)
            {
                Console.Write("Enter side 1 : ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter side 2 : ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter angle : ");
                double angle = double.Parse(Console.ReadLine());

                if (a <= 0 || b <= 0 || angle <= 0 || angle >= 180)
                {
                    throw new ArgumentOutOfRangeException();
                }
                    
                Console.WriteLine("\nThe area is : {0:F2}", AreaByTwoSidesAndAngle(a, b, angle));
            }
            else
            {
                Console.WriteLine("\nError! Invalid input data!\n");
            }
            
            PrintSeparateLine();
        }

        static double AreaBySideAndAltitude(double a, double altitude)
        {
            double area = (a * altitude) / 2;
            return area;
        }

        static double AreaByThreeSides(double a, double b, double c)
        {
            double semiperimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiperimeter *
                                (semiperimeter - a) *
                                (semiperimeter - b) * 
                                (semiperimeter - c));
                             
            return area;
        }

        static double AreaByTwoSidesAndAngle(double a, double b, double angle)
        {
            double area = (a * b * Math.Sin(angle * (Math.PI / 180))) / 2;
            return area;
        }

        static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
