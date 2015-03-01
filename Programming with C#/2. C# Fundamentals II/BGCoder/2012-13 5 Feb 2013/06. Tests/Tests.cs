using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Tests
{
    class Tests
    {
        static void Main()
        {
            // arr in Base 168
            int numBase = 168;
            string[] arr = GetArrayOfNumberBase(numBase);



            // read input
            string input = Console.ReadLine();

            // calculate
            ulong subResult = 0;
            ulong result = 0;
            bool isCalcResult = false;
            int count = 0;
            int pow = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                ulong lowerChar = 0;
                ulong upperChar = 0;
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    lowerChar = (ulong) (input[i] + 1 - 'a') * 26;

                }
                else if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    upperChar = (ulong) (input[i] - 'A');

                }

                if (i > 0 && (input[i] >= 'A' && input[i] <= 'Z') && (input[i - 1] >= 'a' && input[i - 1] <= 'z') || (input[i] >= 'a' && input[i] <= 'z'))//|| i >= 1)
                {
                    count++;
                    subResult += lowerChar;
                    subResult += upperChar;

                    if (count == 2)
                    {
                        isCalcResult = true;
                        count = 0;
                    }
                }
                else if (count == 0)
                {
                    subResult += upperChar;
                    isCalcResult = true;
                }
                if (isCalcResult)
                {
                    result += subResult * (ulong) Math.Pow(numBase, pow);
                    subResult = 0;
                    pow++;
                    isCalcResult = false;
                }
            }

            // output
            Console.WriteLine(result);
            // Console.WriteLine(ulong.MaxValue);

        }

        private static string[] GetArrayOfNumberBase(int numBase)
        {
            string[] arr = new string[numBase];
            for (int i = 0; i < numBase; i++)
            {
                if (i < 26)
                {
                    arr[i] = string.Format("{0}", (char) ((i % 26) + 'A'));
                }
                else
                {
                    arr[i] = string.Format("{0}{1}", (char) ((i / 26 - 1) + 'a'), (char) ((i % 26) + 'A'));
                }
            }

            return arr;
        }
    }
}
