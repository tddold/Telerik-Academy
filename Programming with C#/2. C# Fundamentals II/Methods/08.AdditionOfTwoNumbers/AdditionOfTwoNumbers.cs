using System;
using System.Collections.Generic;
using System.Linq;

/*Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
*/

class AdditionOfTwoNumbers
{
    static bool IsCorrectNumber(string number)
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

    static List<int> AccumulateTwoNumbers(string number1, string number2)
    {
        var a = number1.Select(ch => ch - '0').ToArray();
        var b = number2.Select(ch => ch - '0').ToArray();

        Array.Reverse(a);
        Array.Reverse(b);

        List<int> result = new List<int>(Math.Max(a.Length, b.Length));

        int carry = 0;

        for (int i = 0; i < result.Capacity; i++)
        {
            int num = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + carry;
            carry = num / 10;
            result.Add(num % 10);
        }

        if (carry > 0)
        {
            result.Add(carry);
        }

        return result;
    }

    static void PrintResult(List<int> result)
    {
        
        for (int i = result.Count-1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }

        Console.WriteLine("\n");
    }

    static void Main()
    {
        Console.Write("Enter number 1:");
        string number1 = Console.ReadLine();
        Console.Write("Enter number 2:");
        string number2 = Console.ReadLine();

        if (IsCorrectNumber(number1) && IsCorrectNumber(number2))
        {
            List<int> result = AccumulateTwoNumbers(number1, number2);

            Console.Write("\nNumber1{0,8}\nNumber2{1,8}\n", number1, number2);
            Console.Write(new string('-', 16));
            Console.Write("\nResult:   ");
            PrintResult(result);
        }
        else
        {
            Console.WriteLine("\n-> You have entered an invalid number(s)...\n");
        }        
    }
}