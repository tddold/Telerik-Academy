/*Problem 3. English digit
Write a method that returns the last digit of given integer as an English word.
Examples:
|input	|output
|512	|two
|1024	|four
|12309	|nine*/

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Title = "Problem 3. English digit";

        Console.WriteLine("Problem 3. English digit!");
        PrintSeparateLine();

        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        string strNumber = GetLastDigit(number);
        Console.WriteLine("\nName of last digit with English word is: {0}", strNumber);

        PrintSeparateLine();
    }

    static string GetLastDigit(int number)
    {
        switch (number % 10)
        {
            case 0:
                return "Zero";
                break;
            case 1:
                return "One";
                break;
            case 2:
                return "Two";
                break;
            case 3:
                return "Three";
                break;
            case 4:
                return "Four";
                break;
            case 5:
                return "Five";
                break;
            case 6:
                return "Six";
                break;
            case 7:
                return "Seven";
                break;
            case 8:
                return "Eight";
                break;
            case 9:
                return "Nine";
                break;
            default:
                return "Unknown digit!";
        }
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}