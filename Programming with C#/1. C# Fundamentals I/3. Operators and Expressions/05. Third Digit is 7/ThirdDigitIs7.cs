/*Problem 5. Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7.*/

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Title = "Third Digit is 7?";

        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 40));
        Console.Write("Third digit of the number is 7: --> ");

        if ((number / 100) % 10 == 7)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}