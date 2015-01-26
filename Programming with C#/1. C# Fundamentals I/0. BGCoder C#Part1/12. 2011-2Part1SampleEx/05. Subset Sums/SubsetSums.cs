using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace _05.Subset_Sums
{
    class SubsetSums
    {
        static BigInteger count = 0;
        static bool[] used;
        static bool isFirst = true;

        static void Main()
        {
            //if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
            //{
            //    Console.SetIn(new StreamReader("input.txt"));
            //}
            BigInteger s = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            BigInteger[] numbers = new BigInteger[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = BigInteger.Parse(Console.ReadLine());
            }
            used = new bool[n];
            GenerateCombination(0, 0,numbers,new BigInteger[n],s);
            Console.WriteLine(count);
        }

        private static void GenerateCombination(int index,int start, BigInteger[] numbers,BigInteger[] newNumbers,BigInteger k)
        {
            if (!isFirst)
            {
                BigInteger sum = 0;
                for (int i = 0; i < newNumbers.Length; i++)
                {
                    sum += newNumbers[i];
                }
                if (sum == k)
                {
                    count++;
                }
            }
            isFirst = false;
            
            Console.WriteLine(String.Join(",", newNumbers));

            if (index == numbers.Length)
            {
                return;
            }

            for (int i = start; i < numbers.Length; i++)
            {
                if (!used[i])
                {
                    newNumbers[index] = numbers[i];
                    used[i] = true;
                    GenerateCombination(index + 1,i+1, numbers, newNumbers, k);
                    newNumbers[index] = 0;
                    used[i] = false;
                }
            }

            //GenerateCombination(index + 1, numbers, newNumbers,k);
            //for (int i = 0; i < 2; i++)
            //{
            //    newNumbers[index] =1;

            //    GenerateCombination(index+1,numbers,newNumbers);
            //    newNumbers[index] = 0;
            //}
        }
    }
}
