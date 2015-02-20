/*Problem 11. Adding polynomials
Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:
x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

Problem 12. Subtracting polynomials
Extend the previous program to support also subtraction and multiplication of polynomials.
 */

using System;
using System.Linq;

class TwoPolynomials
{
    static void Main()
    {
        Console.Title = "Problem 11. Adding polynomials and Problem 12. Subtracting polynomials";

        Console.WriteLine("Problem 11. Adding polynomials and Problem 12. Subtracting polynomials!");
        PrintSeparateLine();

        decimal[] firstPolynom = EnterPolynom(out firstPolynom);
        PrintSeparateLine();

        Console.WriteLine("Print first polinom:\n");
        PrintPolinom(firstPolynom);
        PrintSeparateLine();

        decimal[] secondPolynom = EnterPolynom(out secondPolynom);
        PrintSeparateLine();

        Console.WriteLine("Print second polinom:\n");
        PrintPolinom(secondPolynom);
        PrintSeparateLine();

        Console.WriteLine(" Adding polynomials:\n");
        AddingPolynomials(firstPolynom, secondPolynom);
        PrintSeparateLine();

        Console.WriteLine(" Subtraction polynomials:\n");
        SubtractionPolynomials(firstPolynom, secondPolynom);
        PrintSeparateLine();

        Console.WriteLine(" Multiplication polynomials:\n");
        MultiplicationPolynomials(firstPolynom, secondPolynom);
        PrintSeparateLine();
    }

    private static decimal[] EnterPolynom(out decimal[] polynom)
    {
        Console.Write("Enter the exponent of the polinom :");
        byte expo = byte.Parse(Console.ReadLine());
        Console.WriteLine();

        polynom = new decimal[expo + 1];

        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            Console.Write(" x^" + i + ": ");
            polynom[i] = decimal.Parse(Console.ReadLine());
        }

        return polynom;
    }

    static void AddingPolynomials(decimal[] firstPolynom, decimal[] secondPolynom)
    {
        PrintPolinom(firstPolynom);
        Console.Write("   +\n");
        PrintPolinom(secondPolynom);
        Console.Write("   =\n");

        int biggerLenght = Math.Max(firstPolynom.Length, secondPolynom.Length);
        bool isFirstBigger = firstPolynom.Length >= secondPolynom.Length ? true : false;
        bool isSecondBigger = !isFirstBigger;
        bool isZero = true;

        var result = new decimal[biggerLenght];

        for (int i = biggerLenght - 1; i >= 0; i--)
        {
            if (i < firstPolynom.Length && i < secondPolynom.Length)
            {
                result[i] = firstPolynom[i] + secondPolynom[i];
                if (result[i] != 0)
                {
                    isZero = false;
                }
            }
            else if (isFirstBigger)
            {
                result[i] = firstPolynom[i];
            }
            else if (isSecondBigger)
            {
                result[i] = secondPolynom[i];
            }
        }

        if (!isZero)
        {
            PrintPolinom(result);
        }
        else
        {
            Console.WriteLine("   0\n");
        }
    }

    static void SubtractionPolynomials(decimal[] firstPolynom, decimal[] secondPolynom)
    {
        PrintPolinom(firstPolynom);
        Console.Write("   -\n");
        PrintPolinom(secondPolynom);
        Console.Write("   =\n");

        int biggerLenght = Math.Max(firstPolynom.Length, secondPolynom.Length);
        bool isFirstBigger = firstPolynom.Length >= secondPolynom.Length ? true : false;
        bool isSecondBigger = !isFirstBigger;
        bool isZero = true;

        var result = new decimal[biggerLenght];

        for (int i = biggerLenght - 1; i >= 0; i--)
        {
            if (i < firstPolynom.Length && i < secondPolynom.Length)
            {
                result[i] = firstPolynom[i] - secondPolynom[i];
                if (result[i] != 0)
                {
                    isZero = false;
                }
            }
            else if (isFirstBigger)
            {
                result[i] = firstPolynom[i];
            }
            else if (isSecondBigger)
            {
                result[i] = -secondPolynom[i];
            }
        }

        if (!isZero)
        {
            PrintPolinom(result);
        }
        else
        {
            Console.WriteLine("   0\n");
        }
    }

    private static void MultiplicationPolynomials(decimal[] firstPolynom, decimal[] secondPolynom)
    {
        PrintPolinom(firstPolynom);
        Console.Write("   *\n");
        PrintPolinom(secondPolynom);
        Console.Write("   =\n");

        var result = new decimal[firstPolynom.Length + secondPolynom.Length];

        for (int i = 0; i < firstPolynom.Length; i++)
        {
            for (int j = 0; j < secondPolynom.Length; j++)
            {
                result[i + j] += firstPolynom[i] * secondPolynom[j];
            }
        }

        PrintPolinom(result);
    }

    static void PrintPolinom(decimal[] polynom)
    {
        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            if (i == polynom.Length - 1 && polynom[i] != 0)
            {
                Console.Write("    {0}{1}x^{2} ", polynom[i] > 0 ? string.Empty : "-", Math.Abs(polynom[i]), i);
            }
            else if (i == 0)
            {
                if (polynom[i] < 0)
                {
                    Console.Write("{0}{1} ", "- ", -polynom[i]);
                }
                else if (polynom[i] > 0)
                {
                    Console.Write("{0}{1} ", "+ ", polynom[i]);
                }
            }
            else
            {
                if (polynom[i] < 0)
                {
                    Console.Write("{0}{1}x^{2} ", "- ", -polynom[i], i);
                }
                else if (polynom[i] > 0)
                {
                    Console.Write("{0}{1}x^{2} ", (polynom[polynom.Length - i] != 0 ? "+ " : string.Empty), polynom[i], i);
                }
            }




        }

        Console.WriteLine();
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}