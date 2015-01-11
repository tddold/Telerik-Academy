/*Problem 9. Sum of n Numbers
Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.*/

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Title = "Sum of n Numbers";

        Console.WriteLine("Sum of n Numbers!");
        Console.WriteLine(new string('-', 40));

        Console.Write("Enter number of numbers: ");
        int cheskNumbers;
        while (!int.TryParse(Console.ReadLine(), out cheskNumbers) || cheskNumbers <= 0)
        {
            Console.Write("Invalid number! Enter number > 0: ");
        }

        double number;
        double sum = 0;
        for (int i = 1; i <= cheskNumbers; i++)
        {
            Console.Write("Enter numbers: {0} = ", i);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid parameter! Enter numbers: {0} = ", i);
            }

            sum +=number;

        }

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Sum = {0}", sum);
    }
}