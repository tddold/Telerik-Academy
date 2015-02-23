/*Problem 5. Hexadecimal to binary
Write a program to convert hexadecimal numbers to binary numbers (directly).*/

using System;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Title = "Problem 5. Hexadecimal to binary";

        Console.WriteLine("Problem 5. Hexadecimal to binary!");
        PrintSeparateLine();

        Console.Write("Enter Hexadecimal number: ");
        string number = Console.ReadLine();

        Console.WriteLine("\nHexadecimal to binary number {0} -> {1}", number, HexdecimalToBinaryNumber(number));
        PrintSeparateLine();
    }

    static string HexdecimalToBinaryNumber(string hex)
    {
        hex = StringParse(hex);

        StringBuilder binary = new StringBuilder();
        bool isUsed = false;

        for (int i = 0; i < hex.Length; i++)
        {
            if (hex[i] < 10 + '0')
            {
                if (isUsed)
                {
                    binary.Append(Convert.ToString(hex[i] - '0', 2).PadLeft(4, '0'));
                }
                else
                {
                    binary.Append(Convert.ToString(hex[i] - '0', 2));
                    isUsed = true;
                }
            }
            else
            {
                binary.Append(Convert.ToString(hex[i] - 'A' + 10, 2));
                isUsed = true;
            }
        }

        return binary.ToString();
    }

    static string StringParse(string hex)
    {
        char[] digits = new char[hex.Length];

        for (int i = 0; i < hex.Length; i++)
        {
            digits[i] = char.ToUpper(hex[i]);
        }

        return string.Join(string.Empty, digits);
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}