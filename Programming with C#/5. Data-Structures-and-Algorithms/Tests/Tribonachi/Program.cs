namespace Tribonachi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long t1 = nums[0];
            long t2 = nums[1];
            long t3 = nums[2];
            long n = nums[3];

            var answer = Slove(t1, t2, t3, n);
            Console.WriteLine(answer);
        }

        private static long Slove(long t1, long t2, long t3, long n)
        {
            if (n == 1)
            {
                return t1;
            }

            if (n == 2)
            {
                return t2;
            }

            if (n == 3)
            {
                return t3;
            }

            for (int i = 4; i <= n; i++)
            {
                long tribNum = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = tribNum;
            }

            return t3;
        }
    }
}
