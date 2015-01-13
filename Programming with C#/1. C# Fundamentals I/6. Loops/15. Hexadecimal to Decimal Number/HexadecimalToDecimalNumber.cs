/*Problem 15. Hexadecimal to Decimal Number
Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Title = "Hexadecimal to Decimal Number";

        // input
        Console.WriteLine("Enter number in Hexadecimal representacion: ");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter Hexadecimal number --> ");
        string hexaNumber = Console.ReadLine();

        // logic
        int count = hexaNumber.Length - 1;
        long decimalNumber = 0;
        int factor = 0;
        for (int i = 0; i < hexaNumber.Length; i++)
        {
            switch (hexaNumber[i])
            {
                case 'A':
                    factor = 10;
                    break;
                case 'B':
                    factor = 11;
                    break;
                case 'C':
                    factor = 12;
                    break;
                case 'D':
                    factor = 13;
                    break;
                case 'E':
                    factor = 14;
                    break;
                case 'F':
                    factor = 15;
                    break;
                default:
                    factor = int.Parse(hexaNumber[i].ToString());
                    break;
            }

            decimalNumber += factor * (long) Math.Pow(16, (count - i));
        }

        // output
        Console.WriteLine(decimalNumber);
    }
}