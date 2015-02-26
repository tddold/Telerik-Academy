/*Problem 11. Format number
Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FormatNumber
{
    static void Main()
    {
        Console.WriteLine("Problem 11. Format number");

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("\n{0,15} - Decimal", number);
        Console.WriteLine("{0,15:X} - Hexadecimal", number);
        Console.WriteLine("{0,15:P} - Percentage", number / 100.0);
        Console.WriteLine("{0,15:E} - Scientific format\n", number);
    }
}