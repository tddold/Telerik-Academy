using System;
/*Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".
*/

class NameOfLastDigit
{
    static string LastDigits(int number)
    {
        number = number % 10;
        Console.WriteLine(number);

        switch (number)
        {
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            case 0: return "Zero";
            default: return "Error";
        }
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Last digits is: {0}", LastDigits(number));
    }
}