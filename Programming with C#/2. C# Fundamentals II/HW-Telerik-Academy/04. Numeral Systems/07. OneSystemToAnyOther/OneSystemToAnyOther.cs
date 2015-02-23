/*Problem 7. One system to any other
Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).*/

using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Title = "Problem 7. One system to any other";

        Console.WriteLine("Problem 7. One system to any other!");
        PrintSeparateLine();

        Console.Write("Enters base S(s >= 2): ");
        int baseS = int.Parse(Console.ReadLine());
        if (baseS < 2)
        {
            throw new ArgumentOutOfRangeException("Base (s) mast be: s >= 2");
        }

        Console.Write("\nEnter positive integer number [base {0}]: ", baseS);
        string number = StringParse();

        Console.Write("\nEnter base to convert D(2 <= d <= 16): ");
        int baseD = int.Parse(Console.ReadLine());
        if (baseD < 2 || baseD > 16)
        {
            throw new ArgumentOutOfRangeException("Base (d) mast be: 2 <= d <= 16");
        }

        string result = DecimalToBase(BaseToDecimal(number, baseS), baseD);

        PrintSeparateLine();

        if (IsValidInput(number, result, baseS, baseD))
        {
            Console.Write("\nResult -> {0} [base {1}] converted to [base {2}] => {3}\n\n", number, baseS, baseD, result);
        }
        else
        {
            Console.WriteLine("\n-> You have entered an invalid number!\n");
        }

        PrintSeparateLine();
    }

    static string StringParse()
    {
        string number = Console.ReadLine();

        // Check for incorrect number
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] < 'A' && number[i] > 'Z' && number[i] < 'a' && number[i] > 'z' && number[i] < '0' && number[i] > '9')
            {
                throw new ArgumentException();
            }

            number = MakeAllLettersLarge(number);
        }

        return number;
    }

    static string MakeAllLettersLarge(string number)
    {
        char[] digits = new char[number.Length];

        for (int i = 0; i < number.Length; i++)
        {
            digits[i] = char.ToUpper(number[i]);
        }

        return string.Join(string.Empty, digits);
    }

    static string DecimalToBase(long number, int baseD)
    {
        string result = string.Empty;

        while (number > 0)
        {
            var digit = number % baseD;

            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else
            {
                result = (char)(digit - 10 + 'A') + result;
            }

            number /= baseD;
        }

        return result;
    }

    static long BaseToDecimal(string number, int baseS)
    {
        long result = 0;

        for (int i = 0; i < number.Length; i++)
        {
            int digit = 0;
            if (number[i] >= '0' && number[i] <= '9')
            {
                digit = number[i] - '0';
            }
            else
            {
                digit = number[i] - 'A' + 10;
            }

            result += digit * (long)Math.Pow(baseS, number.Length - i - 1);
        }

        return result;
    }

    static bool IsValidInput(string number, string result, int baseS, int baseD)
    {
        return string.Compare(DecimalToBase(BaseToDecimal(result, baseD), baseS), number) == 0 ? true : false;
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}