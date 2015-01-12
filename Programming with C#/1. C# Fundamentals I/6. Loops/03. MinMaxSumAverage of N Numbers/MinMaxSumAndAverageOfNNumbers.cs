/*Problem 3. Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Title = "Min, Max, Sum and Average of N Numbers";

        Console.Write("Enter number of sequence of numbers: ");
        int n = int.Parse(Console.ReadLine());
        int[] number = new int[n];
        int min = 0;
        int max = 0;
        int sum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            Console.Write("Number {0} --> ", i+1);
            number[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < number.Length; i++)
        {
            if (number[i] > number[i - 1])
            {
                min = number[i - 1];
                max = number[i];
            }
            else
            {
                max = number[i - 1];
                min = number[i];
            }
        }

        for (int i = 0; i < number.Length; i++)
        {
            sum += number[i];
        }

        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}", min, max, sum, (double) sum / n);
    }
}
