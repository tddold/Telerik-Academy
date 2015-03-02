using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01._9Gag_Numbers
{
    class GagNumbers
    {
        static string GetNumbersOfString(string input)
        {
            string result = "NO";

            switch (input)
            {
                case "-!":
                    return result = "0";
                    break;
                case "**":
                    return result = "1";
                    break;
                case "!!!":
                    return result = "2";
                    break;
                case "&&":
                    return result = "3";
                    break;
                case "&-":
                    return result = "4";
                    break;
                case "!-":
                    return result = "5";
                    break;
                case "*!!!":
                    return result = "6";
                    break;
                case "&*!":
                    return result = "7";
                    break;
                case "!!**!-":
                    return result = "8";
                    break;
                default:
                    break;
            }

            return result;
        }

        static BigInteger CalcMathPow(int power)
        {
            BigInteger result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 9;
            }

            return result;
        }

        static void Main()
        {
            string input = Console.ReadLine();

            // calc
            BigInteger result = 0;

            string partialInput = string.Empty;
            string nineSystemNum = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                partialInput += input[i];

                string currDigits = GetNumbersOfString(partialInput);

                if (currDigits != "NO")
                {
                    nineSystemNum += currDigits;
                    partialInput = string.Empty;
                }
            }

            for (int i = 0; i < nineSystemNum.Length; i++)
            {
                BigInteger digits = BigInteger.Parse(nineSystemNum[i].ToString());
                result += (BigInteger) digits * CalcMathPow((nineSystemNum.Length - 1 - i));
            }

            // output
            //Console.WriteLine(nineSystemNum);
            Console.WriteLine(result);
        }
    }
}
