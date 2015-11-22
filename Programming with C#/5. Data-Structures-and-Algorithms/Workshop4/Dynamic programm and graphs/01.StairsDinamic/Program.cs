namespace _01.StairsDinamic
{
    using System;

    class Program
    {
        static long[,] count;
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            count = new long[n + 1, n + 1];
         
            count[1, 1] = 1;
            count[2, 2] = 1;

            for (int i = 3; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == j)
                    {
                        count[i, j] = 1;
                    }

                    for (int k = 1; k < j && i - j >= k; k++)
                    {
                        count[i, j] += count[i - j, k];
                    }
                }
            }

            long answer = 0;
            for (int i = 1; i < n; i++)
            {
                answer += count[n, i];
            }

            Console.WriteLine(answer);
        }
    }
}
