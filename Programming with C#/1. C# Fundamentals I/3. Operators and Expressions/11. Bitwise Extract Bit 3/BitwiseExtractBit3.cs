/*Problem 11. Bitwise: Extract Bit #3
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/

using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Title = "Bitwise: Extract Bit #3";

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int moveRight = number >> 3;
        int mask = 1;
        int result = moveRight & mask;

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Binay representation: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("After move to right : {0}", Convert.ToString(moveRight, 2).PadLeft(16, '0'));
        Console.WriteLine("The result is --> {0}", result);
    }
}