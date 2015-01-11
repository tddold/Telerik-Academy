/*Problem 12.* Zero Subset
We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.*/

using System;
using System.Collections.Generic;
using System.Linq;

class ZeroSubset
{
    static void Main()
    {
        Console.Title = "Zero Subset";

        Console.Write("Enter 5 integer number separated by space: ");
        string input = Console.ReadLine();

        int[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x)).ToArray();
       
        int a = numbers[0];
        int b = numbers[1];
        int c = numbers[2];
        int d = numbers[3];
        int e = numbers[4];        
        
        // Sum 2 numbers
        int sumAB = a + b;
        int sumAC = a + c;
        int sumAD = a + d;
        int sumAE = a + e;
        int sumBC = b + c;
        int sumBD = b + d;
        int sumBE = b + e;
        int sumCD = c + d;
        int sumCE = c + e;
        int sumDE = d + e;

        // Sum 3 numbers
        int sumABC = sumAB + c;
        int sumABD = sumAB + d;
        int sumABE = sumAB + e;
        int sumBCD = sumBC + d;
        int sumBDE = sumBD + e;
        int sumCDE = sumCD + e;

        // Sum 4 numbers;
        int sumABCD = sumABC + d;
        int sumABDE = sumABD + e;
        int sumBCDE = sumBCD + e;

        // Sum 5 numbers
        int sumAllNumber = a + b + c + d + e;

        // check for zero subset
        bool zeroSubset = sumAB != 0 && sumAC != 0 && sumAD != 0 && sumAE != 0 && sumBC != 0 &&
                          sumBD != 0 && sumBE != 0 && sumCD != 0 && sumCE != 0 && sumDE != 0 && 
                          sumABC != 0 && sumABD != 0 && sumABE != 0 && sumBCD != 0 && sumBDE != 0 &&
                          sumCDE != 0 && sumABCD != 0 && sumABDE != 0 && sumBCDE != 0 && sumAllNumber != 0;

        if (zeroSubset)
        {
            Console.WriteLine("no zero subset");
        }
        else
        {
            if (sumAB == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, sumAB);
            }
            if (sumAC == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, c, sumAC);
            }
            if (sumAD == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, d, sumAD);
            }
            if (sumAE == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", a, e, sumAE);
            }
            if (sumBC == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", b, c, sumBC);
            }
            if (sumBD == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", b, d, sumBD);
            }
            if (sumBE == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", b, e, sumBE);
            }
            if (sumCD == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", c, d, sumCD);
            }
            if (sumCE == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", c, e, sumCE);
            }
            if (sumDE == 0)
            {
                Console.WriteLine("{0} + {1} = {2}", d, e, sumDE);
            }
            if (sumABC == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, sumABC);
            }
            if (sumABD == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, d, sumABD);
            }
            if (sumABE == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", a, b, e, sumABE);
            }
            if (sumBCD == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", b, c, d, sumBCD);
            }
            if (sumBDE == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", b, d, e, sumBDE);
            }
            if (sumCDE == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", b, c, d, e, sumCDE);
            }
            if (sumABCD == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, c, d, sumABCD);
            }
            if (sumABDE == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, d, e, sumABDE);
            }
            if (sumBCDE == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", b, c, d, e, sumBCDE);
            }
            if (sumAllNumber == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, sumAllNumber);
            }
        }
    }

}