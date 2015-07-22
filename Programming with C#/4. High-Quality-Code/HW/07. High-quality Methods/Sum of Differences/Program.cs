using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Differences
{
    class Program
    {
        static void Main()
        {
            // input
            long[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => long.Parse(x))
                .ToArray();

            // calc
            long result = 0;

            for (int i = 1; i < input.Length; i++)
            {
                long A = input[i];
                long B = input[i - 1];
                long bigger = 0;
                long smaller = 0;

                if (A > B)
                {
                    bigger = A;
                    smaller = B;
                }
                else
                {
                    bigger = B;
                    smaller = A;
                }

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


            // output

            Console.WriteLine(result);
        }
    }
}
