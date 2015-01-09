using System;

/*Write a method that reverses the digits of given decimal number. Example: 256  652
*/

class ReverseDigitsOfNumber
{
    public static decimal ReversNumber(decimal number)
    {
        string tmp = number.ToString();
        string result = string.Empty;

        for (int i = tmp.Length - 1; i >= 0; i--)
        {
            result += tmp[i];
        }

        return decimal.Parse(result);
    }

    static void Main()
    {
        Console.Write("Enter number:");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter number is: {0} -> revers number is: {1}", number, ReversNumber(number));
        Console.WriteLine("\n{0} -> {1}\n", number, ReversNumber(number));
    }
}