namespace Sum_of_Differences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumOfDifference
    {
        /// <summary>
        /// The  method that calculates the sum of the differences.
        /// </summary>
        public static void Main()
        {
            // input
            long[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => long.Parse(x))
                .ToArray();

            // logic
            long result = 0;

            result = CalculateSumOfAllOddNumbers(input, result);

            // output
            Console.WriteLine(result);
        }

        /// <summary>
        /// The method that calculates the sum of all odd numbers.
        /// </summary>
        /// <param name="input">Input.</param>
        /// <param name="result">Result.</param>
        /// <returns>Integer number.</returns>
        private static long CalculateSumOfAllOddNumbers(long[] input, long result)
        {
            for (int i = 1; i < input.Length; i++)
            {
                long numberA = input[i];
                long numberB = input[i - 1];
                long bigger = 0;
                long smaller = 0;

                CheckNumberIsBigger(numberA, numberB, ref bigger, ref smaller);

                long diff = bigger - smaller;

                if (diff % 2 == 0)
                {
                    if (i + 2 < input.Length)
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (i + 1 < input.Length)
                    {
                        result += diff;
                        diff = 0;
                    }
                    else
                    {
                        if (diff != 0)
                        {
                            result += diff;
                        }

                        break;
                    }
                }

                diff = 0;
            }

            return result;
        }

        /// <summary>
        /// The method that calculates the greater of two numbers.
        /// </summary>
        /// <param name="numberA">First number.</param>
        /// <param name="numberB">Second number.</param>
        /// <param name="bigger">A greater number.</param>
        /// <param name="smaller">Тhe lower number.</param>
        private static void CheckNumberIsBigger(long numberA, long numberB, ref long bigger, ref long smaller)
        {
            if (numberA > numberB)
            {
                bigger = numberA;
                smaller = numberB;
            }
            else
            {
                bigger = numberB;
                smaller = numberA;
            }
        }
    }
}
