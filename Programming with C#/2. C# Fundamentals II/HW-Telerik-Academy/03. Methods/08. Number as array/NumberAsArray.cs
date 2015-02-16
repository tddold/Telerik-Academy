/*Problem 8. Number as array
Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.*/

using System;
using System.Collections.Generic;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        Console.Title = "Problem 8. Number as array";

        Console.WriteLine("Problem 8. Number as array!");
        PrintSeparateLine();

        Console.Write("Enter first positive number: ");
        string first = Console.ReadLine();

        Console.Write("Enter second positive number: ");
        string second = Console.ReadLine();

        PrintSeparateLine();

        if (IsCorectNumber(first) && IsCorectNumber(second))
        {
            List<int> result = AccumulateTwoNumbers(first, second);

            Console.Write("\nResult: ");
            Console.WriteLine(string.Join(",", result));
        }
        else
        {
            Console.WriteLine("\n-> You have entered an invalid number(s)...\n");
        }

        PrintSeparateLine();
    }

    static List<int> AccumulateTwoNumbers(string first, string second)
    {
        int[] a = first.Select(ch => ch - '0').ToArray();
        int[] b = second.Select(ch => ch - '0').ToArray();

        Array.Reverse(a);
        Array.Reverse(b);

        List<int> result = new List<int>(Math.Max(a.Length, b.Length));

        int carry = 0;

        for (int i = 0; i < result.Capacity; i++)
        {
            int number = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + carry;
            carry = number / 10;
            result.Add(number % 10);
        }

        if (carry > 0)
        {
            result.Add(carry);
        }

        return result;

    }

    static bool IsCorectNumber(string number)
    {
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] < '0' || number[i] > '9')
            {
                return false;
            }
        }

        return true;
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}