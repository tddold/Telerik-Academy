using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Greedy_Dwarf
{
    class GreedyDwarf
    {
        static void Main()
        {
            int[] valley = ReadArray(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;

            for (int i = 0; i < m; i++)
            {
                int[] pattern = ReadArray(Console.ReadLine());
                int currSum = WorkWhithPattern(valley, pattern);

                if (maxSum < currSum)
                {
                    maxSum = currSum;
                }
            }


            Console.WriteLine(maxSum);

        }

        private static int WorkWhithPattern(int[] valley, int[] pattern)
        {
            bool[] isVisted = new bool[valley.Length];

            int currSum = valley[0];
            int currIndex = 0;
            isVisted[currIndex] = true;
            for (int j = 0; true; j++)
            {
                if (j > pattern.Length - 1)
                {
                    j -= pattern.Length;
                }

                int nextStep = pattern[j];
                currIndex += nextStep;
                if (currIndex < 0 || currIndex > valley.Length-1 || isVisted[currIndex])
                {
                    break;
                }

                currSum += valley[currIndex];
                isVisted[currIndex] = true;
            }
            return currSum;
        }

        private static int[] ReadArray(string input)
        {
            int[] arr = input
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            return arr;
        }        
    }
}
