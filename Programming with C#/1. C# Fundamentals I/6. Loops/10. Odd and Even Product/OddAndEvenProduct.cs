/*Problem 10. Odd and Even Product
You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Title = "Odd and Even Product";

        Console.Write("Enter sequence of numbers: ");
        string[] sequenceNumber = Console.ReadLine().Split();
        Console.WriteLine(new string('-', 40));

        int prodactOddNumbers = 1;
        for (int i = 0; i < sequenceNumber.Length; i = i + 2)
        {
            prodactOddNumbers *= int.Parse(sequenceNumber[i]);
        }

        int prodactEvenNumbers = 1;
        for (int i = 1; i < sequenceNumber.Length; i = i + 2)
        {
            prodactEvenNumbers *= int.Parse(sequenceNumber[i]);
        }

        if (prodactOddNumbers == prodactEvenNumbers)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", prodactEvenNumbers);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", prodactOddNumbers);
            if (sequenceNumber.Length == 1)
            {
                Console.WriteLine("even_product = no even numbers");
            }
            else
            {
                Console.WriteLine("even_product = {0}", prodactEvenNumbers);
            }
        }
    }
}