namespace Recursive
{
    using System;

    /// <summary>
    /// Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.
    /// Examples:
    ///          1 1
    /// n=2  ->  1 2
    ///          2 1
    ///          2 2
    /// 
    ///          1 1 1
    ///          1 1 2
    ///          1 1 3
    ///          1 2 1
    /// n=3  ->  ...
    ///          3 2 3
    ///          3 3 1
    ///          3 3 2
    ///          3 3 3
    /// </summary>
    public class NestedLoops
    {
        private static int[] loops;
        private static int n;

        public static void Main()
        {
            Console.Write("N= ");
            n = int.Parse(Console.ReadLine());
            loops = new int[n];
            RecursiveNestedLoops(0);
        }

        private static void RecursiveNestedLoops(int currentLoop)
        {
            if (currentLoop == n)
            {
                PrintLoop();
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                loops[currentLoop] = i;
                RecursiveNestedLoops(currentLoop + 1);
            }
        }

        private static void PrintLoop()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", loops[i]);
            }

            Console.WriteLine();
        }
    }
}
