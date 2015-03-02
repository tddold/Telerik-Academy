using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Zerg___
{
    class Zerg
    {
        static int ConvertToDigits(string digits)
        {
            switch (digits)
            {
                case "Rawr":
                    return 0;
                    break;
                case "Rrrr":
                    return 1;
                    break;
                case "Hsst":
                    return 2;
                    break;
                case "Ssst":
                    return 3;
                    break;
                case "Grrr":
                    return 4;
                    break;
                case "Rarr":
                    return 5;
                    break;
                case "Mrrr":
                    return 6;
                    break;
                case "Psst":
                    return 7;
                    break;
                case "Uaah":
                    return 8;
                    break;
                case "Uaha":
                    return 9;
                    break;
                case "Zzzz":
                    return 10;
                    break;
                case "Bauu":
                    return 11;
                    break;
                case "Djav":
                    return 12;
                    break;
                case "Myau":
                    return 13;
                    break;
                case "Gruh":
                    return 14;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        static long PowerOfFifteen(int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 15;
            }

            return result;
        }

        static void Main()
        {
            string input = Console.ReadLine();
            string digits = string.Empty;

            int position = input.Length / 4 - 1;
            long result = 0;

            for (int i = 0; i < input.Length; i += 4)
            {
                string currDigits = input.Substring(i, 4);

                result += ConvertToDigits(currDigits) * PowerOfFifteen(position);
                position--;
            }

            Console.WriteLine(result);

        }
    }
}
