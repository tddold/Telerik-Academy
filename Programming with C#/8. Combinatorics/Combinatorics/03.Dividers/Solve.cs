namespace Dividers
{
    using System;
    using System.Text;

    public class Solve
    {
        const int MaximalNumber = 1000000;

        static int[] elements;
        static int[] permutations;
        static bool[] used;
        static int bestNumber = MaximalNumber;
        static int bestDividersCount = MaximalNumber;

        public static void Main()
        {
            ParseInput();

            Permutations(0);

            Console.WriteLine(bestNumber);
        }

        private static void ParseInput()
        {
            int N = int.Parse(Console.ReadLine());
            elements = new int[N];
            permutations = new int[N];
            used = new bool[N];

            for (int i = 0; i < N; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }
        }

        private static void Permutations(int index)
        {
            if (index >= permutations.Length)
            {
                var number = int.Parse(GetNumber());
                var dividers = FindDividersCount(number);

                if (bestDividersCount > dividers ||
                    bestDividersCount == dividers &&
                    number < bestNumber)
                {
                    bestNumber = number;
                    bestDividersCount = dividers;
                }

                return;
            }

            for (int i = 0; i < permutations.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }

                used[i] = true;

                permutations[index] = i;
                Permutations(index + 1);

                used[i] = false;
            }
        }

        private static int FindDividersCount(int number)
        {
            int dividersCount = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    dividersCount++;
                }
            }

            return dividersCount;
        }

        private static string GetNumber()
        {
            var number = new StringBuilder();

            for (int i = 0; i < permutations.Length; i++)
            {
                number.Append(elements[permutations[i]]);
            }

            return number.ToString();
        }
    }
}
