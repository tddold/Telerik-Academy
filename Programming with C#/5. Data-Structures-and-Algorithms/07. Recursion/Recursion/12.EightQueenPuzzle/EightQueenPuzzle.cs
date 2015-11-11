namespace Recursion
{
    /*
    12. *Write a recursive program to solve the "8 Queens Puzzle" with backtracking.
        */

    using System;
    using System.Diagnostics;

    public class EightQueenPuzzle
    {
        private const int BoardSize = 13;
        private const string QueenSign = "Q";
        private const string EmptyCellSign = ".";

        private static readonly Stopwatch sw = new Stopwatch();

        // The queen (i, j)
        private static readonly int[] queenCell = new int[BoardSize];

        // Optimization -> quick check for passable cell
        // Check if there is queen on that column
        private static readonly bool[] columns = new bool[BoardSize];

        // Check if there is queen on that left diagonal
        private static readonly bool[] leftDiagonal = new bool[2 * BoardSize];

        // Check if there is queen on that right diagonal 
        private static readonly bool[] rightDiagonal = new bool[2 * BoardSize]; 

        private static bool isSolutionFound = false;       

        public static void Main()
        {
            sw.Start();

            int solutionsCount = 0;
            SolveQueenPuzzle(0, ref solutionsCount, findAllSolutions: true, printSolutions: false);

            sw.Stop();

            Console.WriteLine("Found {0} solutions.", solutionsCount);
            Console.WriteLine("\nElapsed time: {0}\n", sw.Elapsed);
        }

        private static void SolveQueenPuzzle(int row, ref int solutionsCount, bool printSolutions = false, bool findAllSolutions = false)
        {
            if (isSolutionFound && !findAllSolutions)
            {
                return;
            }

            if (row == BoardSize)
            {
                solutionsCount++;
                isSolutionFound = true;

                if (printSolutions)
                {
                    PrintChessBoard();
                }
            }

            for (int col = 0; col < BoardSize; col++)
            {
                // Check for passable cell
                if (!columns[col] && !leftDiagonal[row + col] && !rightDiagonal[BoardSize + (row - col)])
                {
                    columns[col] = leftDiagonal[row + col] = rightDiagonal[BoardSize + (row - col)] = true; // Visited
                    queenCell[row] = col;

                    SolveQueenPuzzle(row + 1, ref solutionsCount, printSolutions, findAllSolutions);

                    columns[col] = leftDiagonal[row + col] = rightDiagonal[BoardSize + (row - col)] = false; // Backtracking
                }
            }
        }

        private static void PrintChessBoard()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    Console.Write("{0,-2} ", queenCell[i] == j ? QueenSign : EmptyCellSign);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
