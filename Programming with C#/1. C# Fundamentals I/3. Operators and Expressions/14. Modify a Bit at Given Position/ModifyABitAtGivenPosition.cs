/*Problem 14. Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.*/

using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Title = "Modify a Bit at Given Position";

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter index: ");
        int index = int.Parse(Console.ReadLine());
        Console.Write("Enter value (0 or 1): ");
        int val = int.Parse(Console.ReadLine());

        int mask = 1;
        int result;
       
        if (val == 1)
        {
            mask = mask << index;
            result = number | mask;
        }
        else
        {
            mask = ~(mask << index);
            result = number & mask;
        }

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Binay representation             : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Mask                             : {0}", Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine("Binary representation result is  : {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("The result is --> {0}", result);      
    }
}