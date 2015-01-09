using System;

class Test
{
    static void Main()
    {
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());

        decimal factorial = Factorial(number);
        Console.WriteLine("{0}! = {1}", number, factorial);
    }

    static decimal Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }

    }
}