/*Problem 13. Binary to Decimal Number
Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Title = "Binary to Decimal Number";

        // input
        Console.WriteLine("Enter number in Binary representacion: ");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter Binary number --> ");
        string binaryNumber = Console.ReadLine();

        // logic
        int count = binaryNumber.Length - 1;
        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += long.Parse(binaryNumber[i].ToString()) * (long) Math.Pow(2, (count - i));
        }

        // output
        Console.WriteLine(decimalNumber);
    }
}