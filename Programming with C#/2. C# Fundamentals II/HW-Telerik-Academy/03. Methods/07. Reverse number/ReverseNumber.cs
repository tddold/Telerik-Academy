/*Problem 7. Reverse number
Write a method that reverses the digits of given decimal number.
Example:
|input	|output
|256	|652
 */

using System;
using System.Text;

class ReverseNumber
{
    static void Main()
    {
        Console.Title = "Problem 7. Reverse number";

        Console.WriteLine("Problem 7. Reverse number!");
        PrintSeparateLine();

        Console.Write("Enter input number: ");
        string number = Console.ReadLine();

        int result = PrintReverNumber(number);

        Console.WriteLine("\n{0} -> {1}",number, result);

        PrintSeparateLine();
    }

    static int PrintReverNumber(string number)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = number.Length-1; i >= 0; i--)
        {
            sb.Append(number[i]);
        }

        return int.Parse(sb.ToString());
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}