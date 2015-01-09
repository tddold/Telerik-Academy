using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdNum = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(firstNum);
        }
        else if (n == 2)
        {
            Console.WriteLine(secondNum);
        }
        else if (n == 3)
        {
            Console.WriteLine(thirdNum);
        }
        else
        {
            BigInteger result = 0;
            for (int i = 3; i < n; i++)
            { 
                result = firstNum + secondNum + thirdNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = result;
            }

            Console.WriteLine(result);
        }
    }
}