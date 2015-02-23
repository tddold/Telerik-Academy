/*Problem 2. Binary to decimal
Write a program to convert binary numbers to their decimal representation.*/

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Title = "Problem 2. Binary to decimal";

        Console.WriteLine("Problem 2. Binary to decimal!");
        PrintSeparateLine();

        Console.Write("Enter binary number: ");
        string number = Console.ReadLine();

        Console.WriteLine("\nBinary to decimal number {0} -> {1}", number, BinaryToDecimalNumber(number));
        PrintSeparateLine();
    }

    static long BinaryToDecimalNumber(string binaryNumber)
    {
        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int digit = binaryNumber[binaryNumber.Length - i - 1] - '0';
            decimalNumber += digit * (long)Math.Pow(2, i);
        }

        return decimalNumber;
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}