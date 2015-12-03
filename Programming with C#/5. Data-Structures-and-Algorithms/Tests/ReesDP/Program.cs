using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReesDP
{
    class Program
    {
        static long[,,,,] memo = new long[11, 11, 11, 11, 5];

        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            memo[0, 0, 0, 0, 0] = 1;
            memo[0, 0, 0, 0, 1] = 1;
            memo[0, 0, 0, 0, 2] = 1;
            memo[0, 0, 0, 0, 3] = 1;

            for (int countA = 0; countA <= a; countA++)
            {
                for (int countB = 0; countB <= b; countB++)
                {
                    for (int countC = 0; countC <= c; countC++)
                    {
                        for (int countD = 0; countD <= d; countD++)
                        {
                            if (countA == 0 && countB == 0 && countC == 0 && countD == 0)
                            {
                                continue;
                            }

                            for (int type = 0; type < 4; type++)
                            {
                                long count = 0;

                                if (type != 0 && countA > 0)
                                {
                                    count += memo[countA - 1, countB, countC, countD, 0];
                                }

                                if (type != 1 && countB > 0)
                                {
                                    count += memo[countA, countB - 1, countC, countD, 1];
                                }

                                if (type != 2 && countC > 0)
                                {
                                    count += memo[countA, countB, countC - 1, countD, 2];
                                }

                                if (type != 3 && countD > 0)
                                {
                                    count += memo[countA, countB, countC, countD - 1, 3];
                                }

                                memo[countA, countB, countC, countD, type] = count;

                            }

                        }
                    }
                }
            }

            long totalCount = 0;

            if (a > 0)
            {
                totalCount += memo[a - 1, b, c, d, 0];
            }

            if (b > 0)
            {
                totalCount += memo[a, b - 1, c, d, 1];
            }

            if (c > 0)
            {
                totalCount += memo[a, b, c - 1, d, 2];
            }

            if (d > 0)
            {
                totalCount += memo[a, b, c, d - 1, 3];
            }

            Console.WriteLine(totalCount);
        }
    }
}
