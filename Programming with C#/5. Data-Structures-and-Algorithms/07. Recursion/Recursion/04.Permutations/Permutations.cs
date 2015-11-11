namespace Recursion
{
    using System;

    /// <summary>
    /// 4. Write a recursive program for generating and printing all permutations of
    ///  the numbers 1, 2, ..., n for given integer number n. Example:
    /// n=3 → {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}
    /// </summary>
    public class Permutations
    {
        private const int N = 3;
        private static readonly int[] permutations = new int[N];
        private static readonly bool[] used = new bool[N];

        public static void Main()
        {
            Console.WriteLine("Permutations without repetition: ");
            PermutationsWithoutReps(0);

            Console.WriteLine("\nPermutations with repetition: ");
            PermutationsWithReps(0);

        }

        private static void PermutationsWithoutReps(int depht)
        {
            if (depht >= N)
            {
                Print();
                return;
            }

            for (int i = 0; i < N; i++)
            {
                if (used[i])
                {
                    continue;
                }

                used[i] = true;
                permutations[depht] = i;
                PermutationsWithoutReps(depht + 1);
                used[i] = false;
            }
        }

        private static void PermutationsWithReps(int depht)
        {
            if (depht >= N)
            {
                Print();
                return;
            }

            for (int i = 0; i < N; i++)
            {
                permutations[depht] = i;
                PermutationsWithoutReps(depht + 1);
            }
        }

        private static void Print()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0} ", permutations[i] + 1);
            }

            Console.WriteLine();
        }
    }
}
