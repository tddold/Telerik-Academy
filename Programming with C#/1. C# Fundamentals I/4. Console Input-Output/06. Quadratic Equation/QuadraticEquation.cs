/*Problem 6. Quadratic Equation
Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

using System;

class QuadraticEquation
{
    static void FormatingPrint(double x1, double x2)
    {
        bool checkX1 = Convert.ToString(x1).IndexOf(".") > 0;
        bool checkX2 = Convert.ToString(x2).IndexOf(".") > 0;
        string index1 = "1";
        string index2 = "2";
        if (x1 == x2)
        {
            Console.WriteLine(checkX1 ? "x{1} = x{2} = {0:0.0}" : "x{1} = x{2} = {0}", x1, index1, index2);
        }
        else
        {
            Console.Write(checkX1 ? "x{1} = {0:0.0}; " : "x{1} = {0}; ", x1, index1);
            Console.WriteLine(checkX1 ? "x{1} = {0:0.0}" : "x{1} = {0}", x2, index2);
        }

    }
    static void Main()
    {
        Console.Title = "Quadratic Equation";

        Console.WriteLine("Enter coefficients a, b, and c of a quadratic equation.");
        Console.WriteLine(new string('-', 60));

        Console.Write("Enter a --> ");
        double a;
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Invalid parameter! Enter a --> ");
        }

        Console.Write("Enter b --> ");
        double b;
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid parameter! Enter b --> ");
        }

        Console.Write("Enter c --> ");
        double c;
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Invalid parameter! Enter c --> ");
        }

        Console.WriteLine(new string('-', 60));

        double determenat;
        double x1;
        double x2;

        if ((b * b) - (4 * a * c) < 0)
        {
            Console.WriteLine("no real roots");

        }
        else
        {
            determenat = Math.Sqrt((b * b) - (4 * a * c));
            x1 = (-b - determenat) / (2 * a);
            x2 = (-b + determenat) / (2 * a);
            FormatingPrint(x1, x2);
        }

        Console.WriteLine(new string('-', 60));
    }
}