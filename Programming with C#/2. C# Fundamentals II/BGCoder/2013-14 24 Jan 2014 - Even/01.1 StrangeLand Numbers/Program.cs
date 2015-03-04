using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01._1_StrangeLand_Numbers
{
    class Program
    {
        const int baseSystem = 7;
        static void Main()
        {
            string text = Console.ReadLine()
                .Replace("f", "0")
                .Replace("bIN", "1")
                .Replace("oBJEC", "2")
                .Replace("mNTRAVL", "3")
                .Replace("lPVKNQ", "4")
                .Replace("pNWE", "5")
                .Replace("hT", "6");

            BigInteger result = 0;
            int pow = 0;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                int currDigits = text[i] - '0';
                result += (ulong)currDigits * Power(pow);
                pow++;
            }

            //for (int i = 0; i < text.Length; i++)
            //{
            //    int currDigits = text[i] - '0';
            //    result *= baseSystem;
            //    result += currDigits;
            //}

            Console.WriteLine(result);
        }

        private static BigInteger Power(int pow)
        {
            BigInteger result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= baseSystem;
            }

            return result;
        }
    }
}
