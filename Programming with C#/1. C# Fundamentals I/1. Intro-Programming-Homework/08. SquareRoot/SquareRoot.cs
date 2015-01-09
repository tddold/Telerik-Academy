//Problem 8. Square Root
//Create a console application that calculates and prints the square root of the number 12345.
//Find in Internet “how to calculate square root in C#”.

using System;

class SquareRoot
{
    static void Main()
    {
        Console.WindowWidth = 50;
        Console.Title = "The Square Root of 12345";
        Console.WriteLine("Print Sqrt Number");
       
        double number = 12345;
        Console.WriteLine();
        Console.WriteLine("Square Root of number 12345 = {0}", Math.Sqrt(number));
    }
}