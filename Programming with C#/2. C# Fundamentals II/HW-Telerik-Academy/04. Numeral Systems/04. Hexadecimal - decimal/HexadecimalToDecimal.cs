/*Problem 4. Hexadecimal to decimal
Write a program to convert hexadecimal numbers to their decimal representation.*/

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Title = "Problem 4. Hexadecimal to decimal";

        Console.WriteLine("Problem 4. Hexadecimal to decimal!");
        PrintSeparateLine();

        Console.Write("Enter Hexadecimal number: ");
        string number = Console.ReadLine();

        Console.WriteLine("\nHexadecimal to decimal number {0} -> {1}", number, HexadecimalToDecimalNumber(number));
        PrintSeparateLine();
    }

    static long HexadecimalToDecimalNumber(string hexadecimalyNumber)
    {
        long decimalNumber = 0;

        for (int i = 0; i < hexadecimalyNumber.Length; i++)
        {
            int digit = 0;
            if (hexadecimalyNumber[i] >= '0' && hexadecimalyNumber[i] <= '9')
            {
                digit = hexadecimalyNumber[i] - '0';
            }
            else if (hexadecimalyNumber[i] >= 'A' && hexadecimalyNumber[i] <= 'F')
            {
                digit = hexadecimalyNumber[i] - 'A' + 10;
            }

            decimalNumber += digit * (long) Math.Pow(16, hexadecimalyNumber.Length - i - 1);
        }

        return decimalNumber;
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));  
    }
}