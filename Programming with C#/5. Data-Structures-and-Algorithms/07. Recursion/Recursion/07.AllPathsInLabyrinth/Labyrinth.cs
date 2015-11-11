namespace Recursion
{
    using System;

    /// <summary>
    /// We are given a matrix of passable and non-passable cells.
    /// Write a recursive program for finding all paths between two cells in the matrix.
    /// </summary>
    public class Labyrinth
    {
        private const char PassableCell = ' ';
        private const char NonPassableCell = '*';
        private const char UsedCell = 's';
        private const char FinalCell = 'e';

        private static int position = 0;
        private static int pathsCount = 0;   
            
        private static char[,] lab = 
            {
                { ' ', ' ', ' ', '*', ' ', ' ', ' ' },
                { '*', '*', ' ', '*', ' ', '*', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', '*', '*', '*', '*', '*', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', 'e' },
            };

        private static char[] directions = new char[lab.GetLongLength(0) * lab.GetLongLength(1)];

        public static void Main()
        {
            FindPath(0, 0);

            Console.WriteLine("\nTotal paths: {0}\n", pathsCount);
        }

        private static void FindPath(int row, int col, int currentLength = 1, char dir = 'S')
        {
            if (!IsCellPassable(row, col))
            {
                return;
            }

            directions[position] = dir;
            position++;

            if (lab[row, col] == FinalCell)
            {
                PintPath(currentLength);
                return;
            }

            if (lab[row, col] == PassableCell)
            {
                lab[row, col] = UsedCell;

                FindPath(row, col - 1, currentLength + 1, 'L'); // left
                FindPath(row - 1, col, currentLength + 1, 'U'); // up
                FindPath(row, col + 1, currentLength + 1, 'R'); // right
                FindPath(row + 1, col, currentLength + 1, 'D'); // down

                lab[row, col] = PassableCell;
            }

            position--;
        }

        private static bool IsCellPassable(int row, int col)
        {
            return row >= 0 && row < lab.GetLength(0) &&
                   col >= 0 && col < lab.GetLength(1) &&
                   lab[row, col] != NonPassableCell;
        }

        private static void PintPath(int currentLength)
        {
            Console.Write("Path #{0} -> cells length: {1} -> Direction: ", ++pathsCount, currentLength);

            for (int i = 1; i < currentLength; i++)
            {
                Console.Write(directions[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
