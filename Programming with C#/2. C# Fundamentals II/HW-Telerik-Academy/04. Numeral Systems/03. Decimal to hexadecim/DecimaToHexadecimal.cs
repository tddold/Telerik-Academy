/*Problem 3. Decimal to hexadecimal
Write a program to convert decimal numbers to their hexadecimal representation.*/

using System;

class DecimaToHexadecimal
{
    static void Main()
    {
        Console.Title = "Problem 3. Decimal to hexadecimal";

        Console.WriteLine("Problem 3. Decimal to hexadecimal!");
        PrintSeparateLine();

        Console.Write("Enter positive number: ");
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine("\nDecimal to hexadecimal number {0} -> {1}", number, DecimalTohexadecimalNumber(number));
        PrintSeparateLine();
    }

    static string DecimalTohexadecimalNumber(long decimalNumber)
    {
        string hexNumber = string.Empty;

        while (decimalNumber > 0)
        {
            var digit = decimalNumber % 16;

            if (digit >= 0 && digit <= 9)
            {
                hexNumber = (char) (digit + '0') + hexNumber; 
            }
            else if (digit >= 10 && digit <= 15)
            {
                hexNumber = (char)(digit - 10 + 'A') + hexNumber;
            }
                       
            decimalNumber /= 16;
        }

        return hexNumber;
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}