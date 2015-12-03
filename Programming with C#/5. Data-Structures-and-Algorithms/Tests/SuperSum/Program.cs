namespace SuperSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static int[] memo;
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = nums[0];
            int n = nums[1];

            memo = new int[n + 1];

            var answer = SuperSum(k, n);
            Console.WriteLine(answer);
        }

        private static int SuperSum(int k, int n)
        {
            int result = 0;

            //if (memo[n] != 0)
            //{
            //    return memo[n];
            //}

            if (k == 0)
            {
                return n;
            }

            for (int i = 1; i <= n; i++)
            {
                result += SuperSum((k - 1), i);
                // memo[i] = result;
            }

            return result;
        }
    }
}
