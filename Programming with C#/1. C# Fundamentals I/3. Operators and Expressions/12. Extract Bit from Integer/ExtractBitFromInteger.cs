/*Problem 12. Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit at index p.*/

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Title = "Extract Bit from Integer";

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter index: ");
        int index = int.Parse(Console.ReadLine());
        int moveRight = number >> index;
        int mask = 1;
        int result = moveRight & mask;

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Binay representation: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("After move to right : {0}", Convert.ToString(moveRight, 2).PadLeft(16, '0'));
        Console.WriteLine("The result is --> {0}", result);
    }
}