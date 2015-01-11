/*Problem 11.* Number as Words
Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.*/

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Title = "Number as Words";

        Console.Write("Enter number between [0...999]: ");
        string number = Console.ReadLine();
        Console.WriteLine(new string('-', 40));

        if (number.Length == 1)
        {
            Console.WriteLine(GiveTheSingularNumbers(number));
        }
        else if (number.Length == 2 && int.Parse(number) < 20)
        {
            Console.WriteLine(GiveTwoDigitsNumbers(number));
        }
        else if (number.Length == 2)
        {
            int firstNumber = int.Parse(number) / 10;
            int seconndNumber = int.Parse(number) % 10;

            string first = GiveTenthsNumbers(firstNumber.ToString());
            string second = GiveTheSingularNumbers(seconndNumber.ToString());

            Console.WriteLine("{0} {1}", first, second.ToLower());
        }
        else if (number.Length == 3)
        {
            int firstNumber = int.Parse(number) / 100;
            int secondNumber = (int.Parse(number) / 10) % 10;
            int thirdNumber = int.Parse(number) % 10;

            if (secondNumber == 0 && thirdNumber == 0)
            {
                string hundredsNumbers = GiveHundredsNumbers(firstNumber.ToString());
                Console.WriteLine(hundredsNumbers);
            }
            else if (secondNumber == 0)
            {
                string hundredsNumbers = GiveHundredsNumbers(firstNumber.ToString());
                string numbers = GiveTheSingularNumbers(thirdNumber.ToString()).ToLower();
                Console.WriteLine("{0} and {1}", hundredsNumbers, numbers);
            }
            else if (thirdNumber == 0)
            {
                string hundredsNumbers = GiveHundredsNumbers(firstNumber.ToString());
                string tenthsNumbers = GiveTenthsNumbers(secondNumber.ToString()).ToLower();
                Console.WriteLine("{0} and {1}", hundredsNumbers, tenthsNumbers);
            }
            else if (secondNumber == 1)
            {
                string hundredsNumbers = GiveHundredsNumbers(firstNumber.ToString());
                string numbers = GiveTwoDigitsNumbers(thirdNumber.ToString()).ToLower();
                Console.WriteLine("{0} and {1}", hundredsNumbers, numbers);
            }
            else
            {
                string hundredsNumbers = GiveHundredsNumbers(firstNumber.ToString());
                string tenthsNumbers = GiveTenthsNumbers(secondNumber.ToString()).ToLower();
                string numbers = GiveTheSingularNumbers(thirdNumber.ToString()).ToLower();
                Console.WriteLine("{0} and {1} {2}", hundredsNumbers, tenthsNumbers, numbers);
            }
        }

        Console.WriteLine(new string('-', 40));
    }

    private static string GiveHundredsNumbers(string firstNumber)
    {
        switch (firstNumber)
        {
            case "1":
                firstNumber = "One hundred";
                break;
            case "2":
                firstNumber = "Two hundred";
                break;
            case "3":
                firstNumber = "Three hundred";
                break;
            case "4":
                firstNumber = "Four hundred";
                break;
            case "5":
                firstNumber = "Five hundred";
                break;
            case "6":
                firstNumber = "Six hundred";
                break;
            case "7":
                firstNumber = "Seven hundred";
                break;
            case "8":
                firstNumber = "Eight hundred";
                break;
            case "9":
                firstNumber = "Nine hundred";
                break;
            default:
                break;
        }
        return firstNumber;
    }

    private static string GiveTenthsNumbers(string firstNumber)
    {
        switch (firstNumber)
        {
            case "1":
                firstNumber = "Ten";
                break;
            case "2":
                firstNumber = "Twenty";
                break;
            case "3":
                firstNumber = "Thirty";
                break;
            case "4":
                firstNumber = "Fourty";
                break;
            case "5":
                firstNumber = "Fifty";
                break;
            case "6":
                firstNumber = "Sixty";
                break;
            case "7":
                firstNumber = "Seventy";
                break;
            case "8":
                firstNumber = "Eighty";
                break;
            case "9":
                firstNumber = "Ninety";
                break;
            default:
                break;
        }
        return firstNumber;
    }

    private static string GiveTwoDigitsNumbers(string number)
    {
        switch (number)
        {
            case "10":
                number = "Ten";
                break;
            case "1":
            case "11":
                number = "Eleven";
                break;
            case "2":
            case "12":
                number = "Twelve";
                break;
            case "3":
            case "13":
                number = "Тhirteen";
                break;
            case "4":
            case "14":
                number = "Fourteen";
                break;
            case "5":
            case "15":
                number = "Fifteen";
                break;
            case "6":
            case "16":
                number = "Sixteen";
                break;
            case "7":
            case "17":
                number = "Seventeen";
                break;
            case "8":
            case "18":
                number = "Eighteen";
                break;
            case "9":
            case "19":
                number = "Nineteen";
                break;
            default:
                break;
        }

        return number;
    }

    private static string GiveTheSingularNumbers(string number)
    {
        switch (number)
        {
            case "0":
                number = "Zero";
                break;
            case "1":
                number = "One";
                break;
            case "2":
                number = "Two";
                break;
            case "3":
                number = "Three";
                break;
            case "4":
                number = "Four";
                break;
            case "5":
                number = "Five";
                break;
            case "6":
                number = "Six";
                break;
            case "7":
                number = "Seven";
                break;
            case "8":
                number = "Eight";
                break;
            case "9":
                number = "Nine";
                break;
            default:
                break;
        }

        return number;
    }
}