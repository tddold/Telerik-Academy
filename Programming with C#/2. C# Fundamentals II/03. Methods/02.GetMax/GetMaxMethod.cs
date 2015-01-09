using System;

/*Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
*/

class GetMaxMethod
{
    static int GetMax(int numberOne, int numberTwo)
    {
        int bigNumber = numberOne;
        if (numberTwo > numberOne)
        {
            bigNumber = numberTwo;
        }

        return bigNumber;
    }

    static void Main()
    {
        Console.Write("Enter n1: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter n2: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Enter n3: ");
        int n3 = int.Parse(Console.ReadLine());

        int bigger = GetMax(n1, n2);

        Console.WriteLine("Biggest number is: {0}", GetMax(bigger, n3));
    }
}