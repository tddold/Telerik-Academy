using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger n1 = BigInteger.Parse(Console.ReadLine());
        BigInteger n2 = BigInteger.Parse(Console.ReadLine());
        BigInteger n3 = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 0;

        switch (n)
        {
            case 1:
                Console.WriteLine(n1);
                break;
            case 2:
                Console.WriteLine(n2);
                break;
            case 3:
                Console.WriteLine(n3);
                break;
            default:
                for (int i = 4; i <= n; i++)
                {
                    result = n1 + n2 + n3;
                    n1 = n2;
                    n2 = n3;
                    n3 = result;
                }

                Console.WriteLine(result);
                break;
        }
    }
}