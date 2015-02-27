/*Problem 1. Square root
Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Problem 1. Square root");
        Console.WriteLine(new string('-', 40));

        try
        {
            Console.Write("Enter integer number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num < 0)
            {
                throw new ArgumentException("Invalid number");
            }

            Console.WriteLine("Square root of number {0} is {1}", num, Math.Sqrt((double) num));
        }
        catch (FormatException)
        {
            Console.WriteLine("\nInvalid number");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }

        Console.WriteLine(new string('-', 40));
    }
}