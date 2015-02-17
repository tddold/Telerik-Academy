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

        Console.WriteLine("Print first polinom:");
        PrintPolinom(firstPolynom);

        decimal[] secondPolynom = EnterPolynom(out secondPolynom);
        PrintSeparateLine();

        Console.WriteLine("Print second polinom:");
        PrintPolinom(secondPolynom);
        PrintSeparateLine();


    }

    private static void PrintPolinom(decimal[] polynom)
    {
        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            if (i == polynom.Length - 1 && polynom[i] !=0)
            {
                Console.Write("    {0}{1}x^{2} ", polynom[i] > 0 ? "" : " -", Math.Abs(polynom[i]), i);
            }
            else if (i == 0)
            {
                if (polynom[i] < 0)
                {
                    Console.Write("{0}{1} ", "- ", -polynom[i]);
                }
                else if(polynom[i] > 0)
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
                    Console.Write("{0}{1}x^{2} ", polynom[polynom.Length - 1] == 0 ? "" : "+ ", polynom[i], i);
                }
            }
        }

        Console.WriteLine();
    }

    private static decimal[] EnterPolynom(out decimal[] polynom)
    {
        Console.Write("Enter the exponent of the polinom :");
        byte expo = byte.Parse(Console.ReadLine());

        polynom = new decimal[expo + 1];

        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            Console.Write("x^" + i + ": ");
            polynom[i] = decimal.Parse(Console.ReadLine());
        }

        return polynom;
 
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}