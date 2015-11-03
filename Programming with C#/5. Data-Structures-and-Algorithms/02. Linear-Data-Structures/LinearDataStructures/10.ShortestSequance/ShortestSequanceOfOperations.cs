namespace _10.ShortestSequance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 10. We are given numbers N and M and the following operations:
    ///     N = N+1
    ///     N = N+2
    ///     N = N*2
    ///     Write a program that finds the shortest sequence of operations from the list above that 
    ///     starts from N and finishes in M.
    ///     Hint: use a queue.
    ///     Example: N = 5, M = 16
    ///     Sequence: 5 → 7 → 8 → 16
    /// </summary>
    public class ShortestSequanceOfOperations
    {
        public static void Main()
        {
            Console.Write("N number: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("M number: ");
            int m = int.Parse(Console.ReadLine());

            var sequence = FindSequence(m, n);

            PrintSequence(sequence);
        }

        private static void PrintSequence(Queue<int> sequence)
        {

            Console.WriteLine("Result: {0}", string.Join(" -> ", sequence.OrderBy(n => n)));
        }

        private static Queue<int> FindSequence(int start, int end)
        {
            var queue = new Queue<int>();
            queue.Enqueue(start);

            var currentNUmber = start;

            while (currentNUmber > end)
            {
                if (currentNUmber / 2 >= end)
                {
                    currentNUmber /= 2;
                }
                else if (currentNUmber - 2 >= end)
                {
                    currentNUmber -= 2;
                }
                else if (currentNUmber - 1 >= end)
                {
                    currentNUmber -= 1;
                }

                queue.Enqueue(currentNUmber);
            }

            return queue;
        }
    }
}
