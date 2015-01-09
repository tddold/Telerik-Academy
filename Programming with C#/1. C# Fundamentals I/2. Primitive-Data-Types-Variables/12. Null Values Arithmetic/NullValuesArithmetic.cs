/*Problem 12. Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        Console.Title = " Null Values Arithmetic";

        int? intNumber = null;
        double? doubleNumber = null;

        Console.WriteLine("This is the integer with Null value: " + intNumber);
        Console.WriteLine("This is the real number with Null value: " + doubleNumber);
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter integer number:");
        intNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter real number:");
        doubleNumber = double.Parse(Console.ReadLine());
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("This is the integer with value: " + intNumber);
        Console.WriteLine("This is the real number with value: " + doubleNumber);
    }
}