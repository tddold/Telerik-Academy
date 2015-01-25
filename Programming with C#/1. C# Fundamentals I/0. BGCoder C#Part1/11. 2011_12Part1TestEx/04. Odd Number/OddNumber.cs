using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace _04.Odd_Number
{
    class OddNumber
    {
        static void Main()
        {
            // http://bgcoder.com/Contests/Practice/Index/3#3

            if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
            {
                Console.SetIn(new StreamReader("input.txt"));
            }

            List<BigInteger> arrayNumbers = new List<BigInteger>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                arrayNumbers.Add(BigInteger.Parse(Console.ReadLine()));
            }

            // logic
            int count = 1;            
            BigInteger result = 0;
            bool[] removeIndex = new bool[n];

            for (int i = 0; i < removeIndex.Length; i++)
            {
                if (!removeIndex[i])
                {
                    removeIndex[i] = true;
                    count = 1;
                    for (int j = i; j < arrayNumbers.Count-1; j++)
                    {
                        if (arrayNumbers[i] == arrayNumbers[j+1])
                        {
                            count++;
                            removeIndex[j + 1] = true;
                        }
                    }
                }

                if (count % 2 != 0)
                {
                    result = arrayNumbers[i];
                    break;
                }
            }

            Console.WriteLine(result);
            // print
            // PrintArrayNumber(arrayNumbers, n);
        }

        private static void PrintArrayNumber(List<BigInteger> arrayNumbers, int n)
        {
            for (int i = 0; i < arrayNumbers.Count; i++)
            {
                Console.Write("{0} ", arrayNumbers[i]);
            }

            Console.WriteLine();
        }
    }
}