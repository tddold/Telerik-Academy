namespace RefactorExam_Cube
{
    using System;

    public class Cube
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int cubeHight = (2 * inputNumber) - 1;
            int cubeWidth = (2 * inputNumber) - 1;
            int[,] matrix = new int[cubeHight, cubeWidth];

            int currRow;
            int currCol;

            DrowOutsideCube(inputNumber, cubeHight, cubeWidth, matrix, out currRow, out currCol);
            DrawInsaideCube(inputNumber, cubeHight, cubeWidth, matrix, ref currRow, ref currCol);

            Print(cubeHight, cubeWidth, matrix);
        }

        private static void DrawInsaideCube(int inputNumber, int cubeHight, int cubeWidth, int[,] matrix, ref int currRow, ref int currCol)
        {
            DrawInsaideBorders(inputNumber, cubeHight, cubeWidth, matrix, ref currRow, ref currCol);
            DrawFrontArea(inputNumber, cubeHight, matrix, ref currRow, ref currCol);
            DrawTopArea(inputNumber, matrix, ref currRow, ref currCol);
            DrawRightArea(inputNumber, cubeHight, cubeWidth, matrix, ref currRow, ref currCol);
        }

        private static void DrowOutsideCube(int inputNumber, int cubeHight, int cubeWidth, int[,] matrix, out int currRow, out int currCol)
        {
            DrawLeftBlankArea(inputNumber, matrix, out currRow, out currCol);
            DrawLeftDiagonal(inputNumber, matrix, ref currRow, ref currCol);
            DrawTopLine(cubeWidth, matrix, ref currRow, ref currCol);
            DrawRightHalfLine(inputNumber, matrix, ref currRow, ref currCol);
            DrawRightBlankLine(inputNumber, cubeHight, cubeWidth, matrix, ref currRow, ref currCol);
            DrawRightDiagonal(inputNumber, cubeHight, cubeWidth, matrix, ref currRow, ref currCol);
            DrawDowanLine(cubeHight, matrix, ref currRow, ref currCol);
            DrawLeftHalfLine(inputNumber, matrix, ref currRow, ref currCol);
        }

        private static void DrawRightArea(int inputNumber, int cubeHight, int cubeWidth, int[,] matrix, ref int currRow, ref int currCol)
        {
            currRow = inputNumber - 1;
            currCol = inputNumber;
            int countRow = 1;
            int counCol = 0;

            while (currCol < cubeWidth - 1)
            {
                while (currRow > countRow)
                {
                    matrix[currRow, currCol] = 3;
                    currRow--;
                    currCol++;
                }

                countRow++;
                counCol++;
                currRow = inputNumber - 1;
                currCol = inputNumber + counCol;
            }

            currRow = inputNumber - 1;
            currCol = cubeWidth - 2;
            countRow = 1;
            counCol = 0;

            while (currCol > inputNumber - 1)
            {
                while (currRow < cubeHight - 1 - countRow)
                {
                    matrix[currRow, currCol] = 3;
                    currRow++;
                    currCol--;
                }

                countRow++;
                counCol++;
                currRow = inputNumber - 1;
                currCol = cubeWidth - 2 - counCol;
            }
        }

        private static void DrawTopArea(int inputNumber, int[,] matrix, ref int currRow, ref int currCol)
        {
            currRow = inputNumber - 2;
            currCol = 2;
            int count = 0;
            while (currCol <= inputNumber - 1)
            {
                while (currRow > 0)
                {
                    matrix[currRow, currCol] = 2;
                    currRow--;
                    currCol++;
                }

                count++;
                currRow = inputNumber - 2;
                currCol = 2 + count;
            }
        }

        private static void DrawFrontArea(int inputNumber, int cubeHight, int[,] matrix, ref int currRow, ref int currCol)
        {
            currRow = inputNumber;
            currCol = 1;

            while (currCol < inputNumber - 1)
            {
                while (currRow < cubeHight - 1)
                {
                    matrix[currRow, currCol] = 1;
                    currRow++;
                }

                currRow = inputNumber;
                currCol++;
            }
        }

        private static void DrawInsaideBorders(int inputNumber, int cubeHight, int cubeWidth, int[,] matrix, ref int currRow, ref int currCol)
        {
            currRow = inputNumber - 1;

            while (currCol < inputNumber)
            {
                matrix[currRow, currCol] = 4;
                currCol++;
            }

            currCol--;

            while (currCol < cubeWidth)
            {
                matrix[currRow, currCol] = 4;
                currRow--;
                currCol++;
            }

            currRow = inputNumber - 1;
            currCol = inputNumber - 1;

            while (currRow < cubeHight)
            {
                matrix[currRow, currCol] = 4;
                currRow++;
            }
        }

        private static void DrawLeftHalfLine(int inputNumber, int[,] matrix, ref int currRow, ref int currCol)
        {
            currCol = 0;

            while (currRow >= inputNumber - 1)
            {
                matrix[currRow, currCol] = 4;
                currRow--;
            }
        }

        private static void DrawDowanLine(int cubeHight, int[,] matrix, ref int currRow, ref int currCol)
        {
            currRow = cubeHight - 1;
            currCol++;

            while (currCol >= 0)
            {
                matrix[currRow, currCol] = 4;
                currCol--;
            }
        }

        private static void DrawRightDiagonal(int inputNumber, int cubeHight, int cubeWidth, int[,] matrix, ref int currRow, ref int currCol)
        {
            currRow = inputNumber - 1;
            currCol = cubeWidth - 1;

            while (currRow < cubeHight)
            {
                matrix[currRow, currCol] = 4;
                currRow++;
                currCol--;
            }
        }

        private static void DrawRightBlankLine(int inputNumber, int cubeHight, int cubeWidth, int[,] matrix, ref int currRow, ref int currCol)
        {
            currRow--;

            while (currCol >= inputNumber)
            {
                while (currRow < cubeHight)
                {
                    matrix[currRow, currCol] = 1;
                    currRow++;
                }

                currRow = inputNumber + cubeWidth - currCol;
                currCol--;
            }
        }

        private static void DrawRightHalfLine(int inputNumber, int[,] matrix, ref int currRow, ref int currCol)
        {
            currCol--;

            while (currRow <= inputNumber - 1)
            {
                matrix[currRow, currCol] = 4;
                currRow++;
            }
        }

        private static void DrawTopLine(int cubeWidth, int[,] matrix, ref int currRow, ref int currCol)
        {
            currRow++;
            currCol--;

            while (currCol < cubeWidth)
            {
                matrix[currRow, currCol] = 4;
                currCol++;
            }
        }

        private static void DrawLeftDiagonal(int inputNumber, int[,] matrix, ref int currRow, ref int currCol)
        {
            currRow = inputNumber - 2;
            currCol = 1;

            while (currRow >= 0)
            {
                matrix[currRow, currCol] = 4;
                currRow--;
                currCol++;
            }
        }

        private static void DrawLeftBlankArea(int inputNumber, int[,] matrix, out int currRow, out int currCol)
        {
            currRow = inputNumber - 2;
            currCol = 0;

            while (currCol < inputNumber - 1)
            {
                while (currRow >= 0)
                {
                    matrix[currRow, currCol] = 1;
                    currRow--;
                }

                currRow = inputNumber - 2 - currCol;

                currCol++;
            }
        }

        private static void Print(int hight, int width, int[,] matrix)
        {
            for (int row = 0; row < hight; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        Console.Write(" ");
                    }
                    else if (matrix[row, col] == 0)
                    {
                        Console.Write(".");
                    }
                    else if (matrix[row, col] == 2)
                    {
                        Console.Write("/");
                    }
                    else if (matrix[row, col] == 3)
                    {
                        Console.Write("X");
                    }
                    else if (matrix[row, col] == 4)
                    {
                        Console.Write(":");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
