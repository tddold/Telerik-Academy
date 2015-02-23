/*Problem 6. binary to hexadecimal
Write a program to convert binary numbers to hexadecimal numbers (directly).*/

using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Title = "Problem 6. binary to hexadecimal";

        Console.WriteLine("Problem 6. binary to hexadecimal!");
        PrintSeparateLine();

        Console.Write("Enter binary number: ");
        string number = Console.ReadLine();

        Console.WriteLine("\nBunary to Hexadecimal number {0} -> {1}", number, BinaryToHexadecimalNumber(number));
        PrintSeparateLine();
    }

    static string BinaryToHexadecimalNumber(string binary)
    {
        string hex = string.Empty;

        for (int i = binary.Length - 1; i >= 0; )
        {
            int number = 0, j = 0;

            for (int pow = 1; j < 4 && i - j >= 0; j++, pow *= 2)
            {
                number += (binary[i - j] - '0') * pow;
            }

            i -= j;
                       
            if (number >= 0 && number <= 9)
            {
                hex = number + hex;
            }
            else if(number >= 10 && number <= 15)
            {
                hex = (char) (number - 10 + 'A') + hex;
            }
        }

        return hex;
    }
   
    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}