/*Problem 1. Decimal to binary
Write a program to convert decimal numbers to their binary representation.*/

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Title = "Problem 1. Decimal to binary";

        Console.WriteLine("Problem 1. Decimal to binary!");
        PrintSeparateLine();

        Console.Write("Enter positive number: ");
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine("\nDecimal to binary number {0} -> {1}", number, DecimalToBinaryNumber(number));
        PrintSeparateLine();
    }

    static string DecimalToBinaryNumber(long decimalNumber)
    {
        string binaryNumber = string.Empty;

        while (decimalNumber > 0)
        {
            var digit = decimalNumber % 2;
            binaryNumber = digit + binaryNumber;
            decimalNumber /= 2;
        }

        return binaryNumber;
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));    
    }
}