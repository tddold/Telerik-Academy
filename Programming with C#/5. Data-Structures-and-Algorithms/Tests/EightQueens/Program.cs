namespace EightQueens
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static int count = 0;

        public static void Main()
        {
            int size = 8;

            SolveQueensProblem(new bool[size, size], new int[size, size], 0);
            Console.WriteLine(count);
        }

        static void SolveQueensProblem(bool[,] board, int[,] occupied, int columnIndex)
        {
            if (columnIndex == board.GetLength(0))
            {
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(0); col++)
                    {
                        if (board[row, col])
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write(" . ");

                        }
                    }

                    Console.WriteLine();
                }

                Console.WriteLine(new string('-', 23));
                count++;
                return;
            }

            for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
            {
                if (occupied[rowIndex, columnIndex] == 0)
                {
                    // Place queen board[rowIndex, columnIndex]
                    board[rowIndex, columnIndex] = true;

                    // Mark impossible elements in board
                    MarkOccupied(occupied, +1, rowIndex, columnIndex);

                    // Recursively call Queens
                    SolveQueensProblem(board, occupied, columnIndex + 1);

                    // Un-mark impossible elements in board
                    board[rowIndex, columnIndex] = false;
                    MarkOccupied(occupied, -1, rowIndex, columnIndex);
                }
            }
        }

        private static void MarkOccupied(int[,] occupied, int value, int row, int column)
        {
            for (int i = 0; i < occupied.GetLength(0); i++)
            {
                occupied[i, column] += value;
                occupied[row, i] += value;

                if (row + i < occupied.GetLength(0) &&
                    column + i < occupied.GetLength(0))
                {
                    occupied[row + i, column + i] += value;
                }

                if (row - i >= 0 &&
                    column + i < occupied.GetLength(0))
                {
                    occupied[row - i, column + i] += value;
                }
            }


        }
    }
}
