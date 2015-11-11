namespace Recursion
{
    using System;

    public class CombinationNK
    {
        private const int N = 3;
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
                Combinations(i, depht + 1);
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
