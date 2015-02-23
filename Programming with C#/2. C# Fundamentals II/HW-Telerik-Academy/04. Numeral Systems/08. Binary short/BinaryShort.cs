/*Problem 8. Binary short
Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/

using System;
using System.Text;

class BinaryShort
{
    static void Main()
    {
        Console.Title = "Problem 8. Binary short";

        Console.WriteLine("Problem 8. Binary short!");
        PrintSeparateLine();

        Console.Write("Enter short number: ");
        ushort number = ushort.Parse(Console.ReadLine());

        Console.WriteLine("\nShort to binary representacion {0} -> {1}", number, ShortToBinary(number));
        PrintSeparateLine();
    }

    static string ShortToBinary(ushort number)
    {
        if (number == 0)
        {
            return new String('0', 16);
        }            

        StringBuilder binary = new StringBuilder();

        for (int bit = 0; bit < 16; bit++)
        {
            binary.Insert(0, (number >> bit) & 1);
        }

        return binary.ToString();
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}