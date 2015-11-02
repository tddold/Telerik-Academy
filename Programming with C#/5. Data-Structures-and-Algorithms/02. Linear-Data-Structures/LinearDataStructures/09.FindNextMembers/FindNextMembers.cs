namespace _09.FindNextMembers
{
    /*
    We are given the following sequence:
    S1 = N;
    S2 = S1 + 1;
    S3 = 2*S1 + 1;
    S4 = S1 + 2;
    S5 = S2 + 1;
    S6 = 2*S2 + 1;
    S7 = S2 + 2;
    ...
    Using the Queue<T> class write a program to print its first 50 members for given N.
    Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
        */

    using System;
    using System.Collections.Generic;

    public class FindNextMembers
    {
        public static void Main()
        {
            Console.Write("Start number: ");
            int startNumbere = int.Parse(Console.ReadLine());

            Console.Write("Count: ");
            int count = int.Parse(Console.ReadLine());

            var sequentce = FindSequence(startNumbere, count);

            PrintResult(sequentce);
        }

        private static void PrintResult(Queue<int> sequentce)
        {
            Console.WriteLine("Result: {0}", string.Join(", ", sequentce));
        }

        private static Queue<int> FindSequence(int startNumbere, int count)
        {
            var container = new Queue<int>();
            var result = new Queue<int>();

            container.Enqueue(startNumbere);

            for (int i = 0; i < count; i++)
            {
                int currentNumber = container.Dequeue();
                result.Enqueue(currentNumber);
                container.Enqueue(currentNumber + 1);
                container.Enqueue((2 * currentNumber) + 1);
                container.Enqueue(currentNumber + 2);
            }

            return result;
        }
    }
}
