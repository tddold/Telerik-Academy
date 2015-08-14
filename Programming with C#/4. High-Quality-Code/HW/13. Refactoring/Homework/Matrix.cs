namespace RotatingWalkInMatrix
{
    using System;
    public static class Matrix
    {
        private static readonly int[] DirX = { 1, 0, -1, -1, 0, 1, -1, 0 };
        private static readonly int[] DirY = { 1, -1, 0, 1, 1, 0, -1, 1 };

        public static int[,] GenerrateMatrix(byte size)
        {
            int[,] matrix = new int[size, size];

            Cell startupCell = FindeFirstEmptyCellExists(matrix);

            if (startupCell != null)
            {
                FillMatrix(matrix, startupCell);
            }

            return matrix;

        }

        private static void FillMatrix(int[,] matrix, Cell startupCell)
        {
            var currentCell = startupCell;
            var dirIndex = 0;

            while (IsCellPossable(matrix, currentCell))
            {
                matrix[currentCell.X, currentCell.Y] = currentCell.Value;

                while (!IsNextCellPassable(matrix, currentCell, dirIndex) &&
                        CanCellMoveSomeWhere(matrix, currentCell, dirIndex))
                {
                    dirIndex = (dirIndex + 1) % DirX.Length;
                }

                currentCell.X += DirX[dirIndex];
                currentCell.Y += DirY[dirIndex];
                currentCell.Value++;
            }

            var nextStartupCell = FindeFirstEmptyCellExists(matrix);

            if (nextStartupCell != null)
            {
                nextStartupCell.Value = currentCell.Value; FillMatrix(matrix, nextStartupCell);
            }
        }

        private static Cell FindeFirstEmptyCellExists(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[row, column] == 0)
                    {
                        var firstEmptyCell = new Cell(row, column);
                        return firstEmptyCell;
                    }
                }
            }

            return null;
        }

        private static bool IsCellPossable(int[,] matrix, Cell currentCell)
        {
            bool isCellPassable = currentCell.X >= 0 && currentCell.X < matrix.GetLength(0) &&
                                  currentCell.Y >= 0 && currentCell.Y < matrix.GetLength(1) &&
                                  matrix[currentCell.X, currentCell.Y] == 0;

            return isCellPassable;

        }

        private static bool IsNextCellPassable(int[,] matrix, Cell currentCell, int dirIndex)
        {
            Cell nextCell = new Cell()
            {
                X = currentCell.X + DirX[dirIndex],
                Y = currentCell.Y + DirY[dirIndex]
            };

            return IsCellPossable(matrix, nextCell);
        }

        private static bool CanCellMoveSomeWhere(int[,] matrix, Cell currentCell, int dirIndex)
        {
            for (int i = 0; i < DirX.Length; i++)
            {
                dirIndex = (dirIndex + 1) % DirX.Length;

                if (IsNextCellPassable(matrix, currentCell, dirIndex))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
