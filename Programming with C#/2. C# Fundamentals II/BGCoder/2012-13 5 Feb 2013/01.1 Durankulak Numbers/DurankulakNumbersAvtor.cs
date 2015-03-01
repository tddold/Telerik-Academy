using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1_Durankulak_Numbers
{
    class DurankulakNumbersAvtor
    {
        static void Main()
        {
            // input
            ulong baseNum = 168;
            string input = Console.ReadLine();

            // calc
            ulong result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currNum = GetCurrentNumber(input, ref i);

                result *= baseNum;

                if (currNum.Length == 1)
                {
                    result += (ulong) (currNum[0] - 'A');
                }
                else
                {
                    result += (ulong) ((currNum[0] + 1 - 'a') * 26);
                    result += (ulong) (currNum[1] - 'A');
                }
            }

            // output


            Console.WriteLine(result);

        }

        private static string GetCurrentNumber(string input, ref int i)
        {
            string currNum = string.Empty;
            if (input[i] >= 'a' && input[i] <= 'z')
            {
                currNum = string.Format("{0}{1}", input[i], input[i + 1]);
                i++;
            }
            else
            {
                currNum = string.Format("{0}", input[i]);
            }
            return currNum;
        }
    }
}
