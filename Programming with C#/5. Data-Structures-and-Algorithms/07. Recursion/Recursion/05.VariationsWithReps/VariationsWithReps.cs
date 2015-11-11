namespace Recursion
{
    using System;

    /// <summary>
    /// 5. Write a recursive program for generating and printing all ordered 
    /// k-element subsets from n-element set (variations Vkn).
    /// Example: n=3, k=2, set = {hi, a, b } →
    /// (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
    /// </summary>
    public class VariationsWithReps
    {
        private const int K = 2;
        private static readonly string[] Elements = { "hi", "a", "b" };

        private static int n;
        private static int[] variations;

        public static void Main()
        {
            n = Elements.Length;
            variations = new int[n];

            Variations(0);
        }

        private static void Variations(int depht)
        {
            if (depht >= K)
            {
                Print();
                return;
            }

            for (int i = 0; i < n; i++)
            {
                variations[depht] = i;
                Variations(depht + 1);
            }
        }

        private static void Print()
        {
            for (int i = 0; i < K; i++)
            {
                Console.Write("{0} ", Elements[variations[i]]);
            }

            Console.WriteLine();
        }
    }
}
