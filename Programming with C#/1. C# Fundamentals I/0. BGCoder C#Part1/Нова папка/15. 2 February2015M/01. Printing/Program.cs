using System;

public class Program
{
    public static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal s = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal sheet = 500;

        decimal totalSheet = (n * s) / sheet;

        decimal result = totalSheet * p;

        Console.WriteLine("{0:F2}", result);
    }
}