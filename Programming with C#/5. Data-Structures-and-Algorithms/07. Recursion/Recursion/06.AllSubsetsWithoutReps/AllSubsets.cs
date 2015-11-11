namespace Recursion
{
    using System;

    /// <summary>
    /// 6. Write a program for generating and printing all subsets of k strings from given
    /// set of strings.
    /// Example: s = {test, rock, fun},
    ///  k=2 → (test rock), (test fun), (rock fun)
    /// </summary>
    public class AllSubsets
    {
        private const int K = 2;
        private static readonly string[] Elements = { "test", "rock", "fun" };

        private static int n;
        private static int[] subsets;

        public static void Main()
        {
            n = Elements.Length;
            subsets = new int[n];

            VariationsSubsets(0, 0);
        }

        private static void VariationsSubsets(int startInedx, int depht)
        {
            if (depht >= K)
            {
                Print();
                return;
            }

            for (int i = startInedx; i < n; i++)
            {
                subsets[depht] = i;
                VariationsSubsets(i + 1, depht + 1);
            }
        }

        private static void Print()
        {
            for (int i = 0; i < K; i++)
            {
                Console.Write("{0} ", Elements[subsets[i]]);
            }

            Console.WriteLine();
        }
    }
}
