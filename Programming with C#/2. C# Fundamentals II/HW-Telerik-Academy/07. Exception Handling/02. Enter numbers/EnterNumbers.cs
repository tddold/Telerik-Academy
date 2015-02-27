/*Problem 2. Enter numbers
Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/

using System;

class EnterNumbers
{
    public const int start = 1;
    public const int end = 100;

    public static void ReadNumber(int start, int end)
    {
        try
        {

            int number = int.Parse(Console.ReadLine());
            if (number > start && number < end)
            {

            }
            else
            {
                throw new ArgumentOutOfRangeException(number.ToString());
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("\nThe input is not a number!");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("\n{0}", ex.Message);
        }
    }

    public static void TenNumbers(int start, int end)
    {
        for (int i = start + 1; i < 10; i++)
        {
            Console.Write(" number {0} -> ", i);
            ReadNumber(start, end);
        }
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void Main()
    {
        Console.WriteLine("Problem 2. Enter numbers");
        PrintSeparateLine();

        Console.WriteLine("Enter intiger number(1-100): ");
        TenNumbers(start, end);

        PrintSeparateLine();
    }
}
