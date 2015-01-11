/*Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/

using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Title = "Formatting Numbers";

        Console.WriteLine("Inpute one integer number (0-500) and two floating-point number.");
        Console.WriteLine(new string('-', 45));
        Console.Write("Enter a (0-500): ");
        Console.Write("{0,11}a --> ", " ");
        int a;
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 500)
        {
            Console.Write("Invalid parameter!");
        }

        Console.Write("Enter flating-point number: ");
        Console.Write("b --> ");

        double b;
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid parameter!");
        }

        Console.Write("Enter flating-point number: ");
        Console.Write("c --> ");

        double c;
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Invalid parameter!");
        }

        Console.WriteLine(new string('-', 45));
        Console.Write("|{0,-10:X}|{1,10}|", a, Convert.ToString(a, 2).PadLeft(10, '0'));

        bool checB = Convert.ToString(b).IndexOf(".") > 0;
        Console.Write(checB ? "{0,10:0.00}|" : "{0,10}|", b);

        bool checkC = Convert.ToString(c).IndexOf(".") > 0;
        if (checkC)
        {
            Console.WriteLine("{0,-10:0.000}|", c);
        }
        else
        {
            Console.WriteLine("{0, -10}|", c);
        }

        Console.WriteLine(new string('-', 45));
    }
}