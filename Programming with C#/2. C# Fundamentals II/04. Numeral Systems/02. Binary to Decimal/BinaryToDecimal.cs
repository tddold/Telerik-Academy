// Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BinaryToDecimal
{
    public static int ConvertToDecimal(string binary)
    {
        int decimalNum = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - 1 - i] - 48 > 1)
            {
                Console.WriteLine("Enter number is wrong!");
            }

            decimalNum += (binary[binary.Length - 1 - i] - 48) * (int)Math.Pow(2, i);
        }

        return decimalNum;
    }

    public static void Main()
    {
        Console.Write("Enter binary number: ");

        string binary = Console.ReadLine();

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Decimal number is: {0}", ConvertToDecimal(binary));
        Console.WriteLine(new string('-', 40));
    }
}