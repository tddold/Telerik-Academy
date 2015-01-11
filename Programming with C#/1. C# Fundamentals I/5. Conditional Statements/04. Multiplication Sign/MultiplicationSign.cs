/*Problem 4. Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Title = "Multiplication Sign";

        Console.WriteLine("Enter three number:");
        Console.Write("a --> ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b --> ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c --> ");
        double c = double.Parse(Console.ReadLine());

        string plus = "+";
        string minus = "-";

        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("Result --> {0}", plus);
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("Result --> {0}", plus);
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("Result --> {0}", plus);
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("Result --> {0}", plus);
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("Result --> {0}", minus);
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("Result --> {0}", minus);
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("Result --> {0}", minus);
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("Result --> {0}", minus);
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Result --> {0}", 0);
        }
    }
}