using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class TribonacciTriangle
{
    static void Main()
    {
        BigInteger firstTribNumbe = BigInteger.Parse(Console.ReadLine());
        BigInteger secondTribNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdTribNumber = BigInteger.Parse(Console.ReadLine());

        int line = int.Parse(Console.ReadLine());

        // solution        
        List<BigInteger> newLine = new List<BigInteger>();

        newLine.Add(firstTribNumbe);
        newLine.Add(secondTribNumber);
        newLine.Add(thirdTribNumber);


        if (line == 1)
        {

            Console.WriteLine(newLine[0]);
        }
        else if (line == 2)
        {
            Console.WriteLine(newLine[0]);
            Console.WriteLine("{0} {1}", newLine[1], newLine[2]);
        }
        else
        {
            Console.WriteLine(newLine[0]);
            Console.WriteLine("{0} {1}", newLine[1], newLine[2]);

            for (int i = 0; i < line * line; i++)
            {
                BigInteger nextNumber = newLine[i] + newLine[i + 1] + newLine[i + 2];
                newLine.Add(nextNumber);
            }

            int nextStartCount = 3;
            for (int i = 3; i <= line; i++)
            {
                int count = 0;
                while (count < i)
                {
                    Console.Write("{0} ", newLine[nextStartCount + count]);
                    count++;
                }
                nextStartCount += i;
                Console.WriteLine();
            }
        }
    }
}