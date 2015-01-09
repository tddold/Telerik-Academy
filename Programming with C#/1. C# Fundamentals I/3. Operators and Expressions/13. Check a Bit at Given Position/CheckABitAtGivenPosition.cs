/*Problem 13. Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.*/

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Title = "Check a Bit at Given Position";

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
        Console.Write("The result value is 1 --> ");
        if (result == 1)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}