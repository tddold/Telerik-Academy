using System;

//For test

class Test
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        decimal factorial = Factorial(n);
        Console.WriteLine("{0}! = {1}", n, factorial);
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