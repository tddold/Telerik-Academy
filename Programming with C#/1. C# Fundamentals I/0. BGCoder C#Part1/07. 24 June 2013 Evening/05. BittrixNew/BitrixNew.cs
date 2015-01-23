using System;
using System.IO;

class BitrixNew
{
    const int subComands = 3;
    const int columnLenght = 8;
    const int maxRow = 4;
    const int maxCol = 8;
    const int colMatrixLenght = 24;
    const int bonusPoints = 10;

    static void Main()
    {
        // http://bgcoder.com/Contests/Practice/Index/93#4

        if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }

        // input
        int allComands = int.Parse(Console.ReadLine());
        int comands = allComands / 4;

        int[,] matrix = new int[maxRow, colMatrixLenght];


        int inputNumber = 0;

        // solution
        string duration = String.Empty;
        int currComands = 0;
        int rowBits = 0;
        int inputBits = 0;
        int isFullBits = 0;
        int currResultBits = 0;
        int result = 0;
        bool isMoveDowan = true;

        while (currComands < comands)
        {
            // get next number
            int currSubComands = 0;
            duration = String.Empty;

            // write input number in matrix
            inputNumber = int.Parse(Console.ReadLine());
            int currRow = 0;
            WriteInputNumberInMatrix(matrix, inputNumber, currRow);

            // save input bits
            rowBits = 0;
            inputBits = GetRowBits(matrix, rowBits, currRow);

            // print matrix after input number
            PrintMatrix(matrix, inputNumber, duration);

            while (currSubComands < subComands)
            {
                // get comands - duration
                isMoveDowan = true;
                duration = Console.ReadLine();

                // check durations
                if (duration == "D") // Down -----------------------------------------------------------------------
                {
                    isFullBits = GetRowBits(matrix, rowBits, currRow);
                    if (isFullBits == 8)
                    {
                        for (int col = 0; col < columnLenght; col++)
                        {
                            matrix[currRow, col] = 0;
                        }

                        currRow++;

                        // print matrix after erase full row
                        PrintMatrix(matrix, inputNumber, duration);

                        currSubComands++;
                        continue;
                    }

                    // check will we be able to move down
                    isMoveDowan = CheckIsMoveDowan(matrix, isMoveDowan, currRow, duration);

                    // move down
                    if (isMoveDowan)
                    {
                        MoveDown(matrix, currRow);
                        currRow++;
                    }

                    // print matrix after move down
                    PrintMatrix(matrix, inputNumber, duration);

                    // check bits after down
                    if (isMoveDowan)
                    {
                        rowBits = GetRowBits(matrix, rowBits, currRow);
                    }

                    rowBits = GetBonusPoints(rowBits, inputBits);

                    if (rowBits == 0)
                    {
                        rowBits = inputBits;
                    }

                }
                else if (duration == "R") // Right -------------------------------------------------------------------
                {
                    // check will we be able to move down
                    isMoveDowan = CheckIsMoveDowan(matrix, isMoveDowan, currRow, duration);

                    bool isOutOfRange = true;
                    isOutOfRange = CheckOutOfRengeRight(matrix, currRow, isOutOfRange);

                    if (isMoveDowan && isOutOfRange)
                    {
                        // shift right
                        ShiftRight(matrix, currRow);

                        // move down
                        if (isMoveDowan)
                        {
                            MoveDown(matrix, currRow);
                            currRow++;
                        }

                        // print matrix after move down
                        PrintMatrix(matrix, inputNumber, duration);

                        // check bits after down
                        if (isMoveDowan)
                        {
                            rowBits = GetRowBits(matrix, rowBits, currRow);
                        }

                        rowBits = GetBonusPoints(rowBits, inputBits);

                    }
                    else if (isMoveDowan) // only move down - don't shift
                    {
                        // check will we be able to move down
                        duration = "D";
                        isMoveDowan = CheckIsMoveDowan(matrix, isMoveDowan, currRow, duration);

                        if (isMoveDowan)
                        {
                            // move down
                            if (isMoveDowan)
                            {
                                MoveDown(matrix, currRow);
                                currRow++;
                            }

                            // print matrix after move down
                            PrintMatrix(matrix, inputNumber, duration);

                            // check bits after down
                            if (isMoveDowan)
                            {
                                rowBits = GetRowBits(matrix, rowBits, currRow);
                            }

                            rowBits = GetBonusPoints(rowBits, inputBits);
                        }
                    }

                    if (rowBits == 0)
                    {
                        rowBits = inputBits;
                    }
                }
                else if (duration == "L") // Left ----------------------------------------------------------------------
                {
                    // check will we be able to move down
                    isMoveDowan = CheckIsMoveDowan(matrix, isMoveDowan, currRow, duration);

                    bool isOutOfRange = true;
                    isOutOfRange = CheckOutOfRangeLeft(matrix, currRow, isOutOfRange);

                    if (isMoveDowan && isOutOfRange)
                    {
                        // shift left
                        ShiftLeft(matrix, currRow);

                        // move down
                        if (isMoveDowan)
                        {
                            MoveDown(matrix, currRow);
                            currRow++;
                        }

                        // check bits after down
                        if (isMoveDowan)
                        {
                            rowBits = GetRowBits(matrix, rowBits, currRow);
                        }

                        rowBits = GetBonusPoints(rowBits, inputBits);
                    }
                    else if (isMoveDowan) // only move down - don't shift
                    {
                        // check will we be able to move down
                        duration = "D";
                        isMoveDowan = CheckIsMoveDowan(matrix, isMoveDowan, currRow, duration);

                        if (isMoveDowan)
                        {
                            // move down
                            if (isMoveDowan)
                            {
                                MoveDown(matrix, currRow);
                                currRow++;
                            }

                            //print matrix after move down
                            PrintMatrix(matrix, inputNumber, duration);

                            // check bits after down
                            if (isMoveDowan)
                            {
                                rowBits = GetRowBits(matrix, rowBits, currRow);
                            }

                            rowBits = GetBonusPoints(rowBits, inputBits);
                        }
                    }

                    if (rowBits == 0)
                    {
                        rowBits = inputBits;
                    }
                }

                // end subcomands --------------------------------------------------------------------------------------

                currSubComands++;
            }

            currResultBits += rowBits;
            Console.WriteLine("Row bits --> {0}\nCurrent all bits --> {1}", rowBits, currResultBits);

            currComands++;
        }

        Console.WriteLine(currResultBits);

        //print matrix
       // PrintMatrix(matrix, inputNumber, duration);
    }

    private static int GetBonusPoints(int rowBits, int inputBits)
    {
        if (rowBits == 8)
        {
            rowBits = inputBits * bonusPoints;
        }
        return rowBits;
    }

    private static void ShiftRight(int[,] matrix, int currRow)
    {
        for (int col = 1; col < columnLenght; col++)
        {
            if (matrix[currRow, col - 1] >= 0 && matrix[currRow, col] == 1)
            {
                matrix[currRow, col - 1] = 1;
                matrix[currRow, col] = 0;
            }
            else
            {
                continue;
            }
        }
    }

    private static void ShiftLeft(int[,] matrix, int currRow)
    {
        for (int col = columnLenght - 1; col >= 0; col--)
        {
            if (matrix[currRow, col + 1] < columnLenght && matrix[currRow, col] == 1)
            {
                matrix[currRow, col + 1] = 1;
                matrix[currRow, col] = 0;
            }
            else
            {
                continue;
            }
        }
    }

    private static bool CheckOutOfRangeLeft(int[,] matrix, int currRow, bool isOutOfRange)
    {
        if (matrix[currRow, 0] == 1)
        {
            isOutOfRange = false;
        }

        return isOutOfRange;
    }

    private static bool CheckOutOfRengeRight(int[,] matrix, int currRow, bool isOutOfRange)
    {
        if (matrix[currRow, columnLenght - 1] == 1)
        {
            isOutOfRange = false;
        }

        return isOutOfRange;
    }

    private static int GetRowBits(int[,] matrix, int rowBits, int currRow)
    {
        rowBits = 0;
        for (int col = 0; col < columnLenght; col++)
        {
            if (matrix[currRow, col] == 1)
            {
                rowBits++;
            }
        }
        return rowBits;
    }

    private static void WriteInputNumberInMatrix(int[,] matrix, int inputNumber, int currRow)
    {
        for (int col = 0; col < maxCol; col++)
        {
            matrix[currRow, col] = (inputNumber >> col) & 1;
        }
    }

    private static void MoveDown(int[,] matrix, int currRow)
    {
        for (int col = 0; col < columnLenght; col++)
        {
            if (matrix[currRow, col] == 1)
            {
                matrix[currRow, col] = 0;
                matrix[currRow + 1, col] = 1;
            }
        }
    }

    private static bool CheckIsMoveDowan(int[,] matrix, bool isMoveDowan, int currRow, string duration)
    {
        if (duration == "D")
        {
            for (int col = 0; col < columnLenght; col++)
            {
                if (matrix[currRow, col] == 1 && matrix[currRow + 1, col] == 1)
                {
                    isMoveDowan = false;
                }
            }
        }
        else if (duration == "L")
        {
            for (int col = 1; col < columnLenght; col++)
            {
                if (matrix[currRow, col - 1] >= 0 && matrix[currRow, col] == 1)
                {
                    if (matrix[currRow + 1, col - 1] == 1)
                    {
                        isMoveDowan = false;
                        return isMoveDowan;
                    }
                }
                else
                {
                    continue;
                }
            }

        }
        else if (duration == "R")
        {
            for (int col = columnLenght - 1; col >= 0; col--)
            {
                if (matrix[currRow, col + 1] < columnLenght && matrix[currRow, col] == 1)
                {
                    if (matrix[currRow + 1, col + 1] == 1)
                    {
                        isMoveDowan = false;
                        return isMoveDowan;
                    }
                }
                else
                {
                    continue;
                }
            }
        }

        return isMoveDowan;
    }

    private static void PrintMatrix(int[,] matrix, int inputNumber, string duration)
    {
        Console.WriteLine("Print input number ({0}) --> duration ({1})", inputNumber, duration);
        Console.WriteLine(new string('-', 40));
        for (int row = 0; row < maxRow; row++)
        {
            for (int col = 0; col < maxCol; col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}