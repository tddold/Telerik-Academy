namespace Recursion
{
    using System;

    /// <summary>
    /// 3. Modify the previous program to skip duplicates:
    /// n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
    /// </summary>
    public class Solve
    {
        private const int N = 4;
        private const int K = 2;
        private static int[] loops = new int[N];

        public static void Main()
        {
            Combinations(0, 0);
        }

        private static void Combinations(int startIndex, int depht)
        {
            if (depht >= K)
            {
                PrintLoop();
                return;
            }

            for (int i = startIndex; i < N; i++)
            {
                loops[depht] = i;
                Combinations(i + 1, depht + 1);
            }
        }

        private static void PrintLoop()
        {
            for (int i = 0; i < K; i++)
            {
                Console.Write("{0} ", loops[i] + 1);
            }

            Console.WriteLine();
        }
    }
}
