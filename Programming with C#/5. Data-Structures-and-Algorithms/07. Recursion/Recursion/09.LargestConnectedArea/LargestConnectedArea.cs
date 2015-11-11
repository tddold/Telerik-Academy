namespace Recursion
{
    using System;

    /// <summary>
    /// 9. Write a recursive program to find the largest connected area of adjacent empty
    /// cells in a matrix.
    /// </summary>
    public class LargestConnectedArea
    {
        private const string VisitedCell = "";
        private const string PassableCell = "x";

        // Passable cell is marked with "x"
        private static readonly string[,] Matrix =
        {
            { "1", "x", "2", "2", "2", "x" },
            { "x", "x", "x", "2", "4", "x" },
            { "4", "x", "1", "2", "x", "x" },
            { "4", "x", "1", "2", "x", "1" },
            { "4", "x", "1", "x", "x", "x" }
        };

        public static void Main()
        {
            PrintMatriix();

            var bestLength = FindLargestConectedArea();

            Console.WriteLine("\nBest area: {0}\n", bestLength != 0 ? string.Format("{0} -> {1} time(s).", PassableCell, bestLength) : "There is no best area.");
        }

        private static int FindLargestConectedArea()
        {
            int bestLength = int.MinValue;

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    var currentLength = 0;

                    FindAreaDFS(i, j, ref currentLength);

                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                    }
                }
            }

            return bestLength;
        }

        private static void FindAreaDFS(int row, int col, ref int currentLength)
        {
            var isNonPassableCell = row < 0 || row >= Matrix.GetLength(0) ||
                                    col < 0 || col >= Matrix.GetLength(1) ||
                                    Matrix[row, col] != PassableCell;

            if (isNonPassableCell)
            {
                return;
            }

            currentLength++;
            Matrix[row, col] = VisitedCell;

            FindAreaDFS(row, col - 1, ref currentLength);
            FindAreaDFS(row, col + 1, ref currentLength);
            FindAreaDFS(row - 1, col, ref currentLength);
            FindAreaDFS(row + 1, col, ref currentLength);
        }

        private static void PrintMatriix()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write("{0, -3}", Matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
