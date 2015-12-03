using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static long[,,,,] memo = new long[11, 11, 11, 11, 5];

        static void Main()
        {
            memo[0, 0, 0, 0, 0] = 1;
            memo[0, 0, 0, 0, 1] = 1;
            memo[0, 0, 0, 0, 2] = 1;
            memo[0, 0, 0, 0, 3] = 1;

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            var answer = PlasceTrees(a, b, c, d, 4);

            Console.WriteLine(answer);
        }

        private static long PlasceTrees(int a, int b, int c, int d, int lastTree)
        {
            //if (a + b + c + d == 0)
            //{
            //    return 1;
            //}

            if (memo[a, b, c, d, lastTree] > 0)
            {
                return memo[a, b, c, d, lastTree];
            }

            long count = 0;

            if (a > 0 && lastTree != 0)
            {
                count += PlasceTrees(a - 1, b, c, d, 0);
            }

            if (b > 0 && lastTree != 1)
            {
                count += PlasceTrees(a, b - 1, c, d, 1);
            }

            if (c > 0 && lastTree != 2)
            {
                count += PlasceTrees(a, b, c - 1, d, 2);
            }

            if (d > 0 && lastTree != 3)
            {
                count += PlasceTrees(a, b, c, d - 1, 3);
            }

            memo[a, b, c, d, lastTree] = count;
            return count;
        }
    }
}
