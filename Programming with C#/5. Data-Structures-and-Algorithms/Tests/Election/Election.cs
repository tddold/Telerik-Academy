namespace Election
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    class Election
    {
        static void Main()
        {
            var k = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var parties = new List<int>();

            for (int i = 0; i < n; i++)
            {
                parties.Add(int.Parse(Console.ReadLine()));
            }

            // For test
            // parties = Enumerable.Repeat(1, 100).ToList();
            // k = 1;


            var answer = Solve(parties, k);
            Console.WriteLine(answer);
        }

        private static BigInteger Solve(List<int> parties, int k)
        {
            var sums = new BigInteger[parties.Sum() + 1];
            sums[0] = 1;
            int maxSum = 0;

            for (int i = 0; i < parties.Count; i++)
            {
                var num = parties[i];
                for (int j = maxSum; j >= 0; j--)
                {
                    // is sum is possible
                    if (sums[j] > 0)
                    {
                        sums[j + num] += sums[j];
                        maxSum = Math.Max(maxSum, j + num);
                    }
                }
            }

            BigInteger combinations = 0;
            for (int i = k; i <= maxSum; i++)
            {
                combinations += sums[i];
            }

            return combinations;
        }
    }
}
