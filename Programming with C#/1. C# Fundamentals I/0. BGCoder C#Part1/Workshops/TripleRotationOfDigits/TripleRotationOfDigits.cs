using System;

class TripleRotationOfDigits
{
    const int n = 3;
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (number > 9)
            {
                int lastDigits = number % 10;
                number /= 10;

                string result = lastDigits.ToString() + number.ToString();

                number = int.Parse(result);
            }
        }

        Console.WriteLine(number);
    }
}