/*Problem 3. Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.*/

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Title = " Divide by 7 and 5";

        Console.Write("Enter integr number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 40));
        Console.Write("The entered number is divided by 7 and 5! --> ");

        if (number % 7 == 0 && number % 5 == 0 && number != 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}