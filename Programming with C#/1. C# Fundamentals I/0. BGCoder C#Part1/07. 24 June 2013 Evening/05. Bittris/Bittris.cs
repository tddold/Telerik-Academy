using System;
using System.IO;

class Bittris
{
    static void Main()
    {
        // http://bgcoder.com/Contests/Practice/Index/93#4

        if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }
        // Console.WriteLine();

        // input

        int totalNumberOfComands = int.Parse(Console.ReadLine());

        const int columnLenght = 8;
        int numberComands = 3;
        int[,] matrix = new int[4, 24];
        string duration = String.Empty;
        int currentRow = 0;

        int result = 0;
        int tmpResult = 0;
        int bonusPoint = 0;
        int resultBeforBonus = 0;
        int resultAfterBonus = 0;
        int tmpBonusPoint = 0;
        int rowBits = 0;
        int rowAfterBonus = 0;
        bool isCheckDuration = false;

        while (totalNumberOfComands > 0)
        {
            int row = 0;
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < columnLenght; i++)
            {
                matrix[row, i] = (inputNumber >> i) & 1;

            }

            Console.WriteLine();
            Console.WriteLine("Print input number {0}", inputNumber);
            PrintMatrix(matrix);


            numberComands = 3;
            currentRow = 0;
            isCheckDuration = false;
            while (numberComands > 0)
            {
                duration = Console.ReadLine();

                isCheckDuration = false;
                if (duration != "R" && duration != "L" && duration != "D")
                {
                    inputNumber = int.Parse(duration);
                    for (int i = 0; i < columnLenght; i++)
                    {
                        matrix[row, i] = (inputNumber >> i) & 1;

                    }
                    duration = Console.ReadLine();
                }

                if (duration == "D" && currentRow + 1 <= 3)
                {
                    // move down

                    // check will we be able to move down
                    isCheckDuration = MoveDown(matrix, currentRow, columnLenght, isCheckDuration);
                    if (isCheckDuration && currentRow == 0)
                    {
                        int checkBits = 0;
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < columnLenght; j++)
                            {
                                if (matrix[i, j] == 1)
                                {
                                    checkBits++;
                                }
                            }
                        }

                        if (checkBits <= columnLenght)
                        {
                            isCheckDuration = false;
                            numberComands--;
                            Console.WriteLine("Duration {0}. Can move left/rigt an down", duration);
                            continue;
                        }

                        totalNumberOfComands = 0;
                        break;
                    }
                    else if (numberComands >= 1 && isCheckDuration)
                    {
                        isCheckDuration = false;
                        numberComands--;
                        Console.WriteLine("Duration {0}. Don't move down", duration);
                        // currentRow--;
                        continue;
                    }

                    // check bonus
                    bonusPoint = GetBonusPoint(matrix, bonusPoint, inputNumber, currentRow, rowBits);

                    // check full line is bits
                    numberComands = MoveDownAftreEraseRow(columnLenght, numberComands, matrix, currentRow, bonusPoint, isCheckDuration);

                    // check bits in line for bonus
                    rowBits = 0;
                    rowBits = GetBitsForBonus(matrix, currentRow, rowBits);
                    if (isCheckDuration)
                    {
                        isCheckDuration = false;
                    }
                    else
                    {
                        currentRow++;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Down");
                    PrintMatrix(matrix);
                }
                else if (duration == "R")
                {
                    // check after the shift to the right will we be able to move down
                    isCheckDuration = MoveDown(matrix, currentRow, columnLenght, isCheckDuration);
                    if (isCheckDuration && currentRow == 0)
                    {
                        // check after the shift to the right will we be able to move down
                        int checkBits = 0;
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < columnLenght; j++)
                            {
                                if (matrix[i, j] == 1)
                                {
                                    checkBits++;
                                }
                            }
                        }

                        if (checkBits <= columnLenght)
                        {
                            isCheckDuration = false;
                            numberComands--;
                            Console.WriteLine("Duration {0}. Can move left/rigt an down", duration);
                        }
                        else
                        {
                            totalNumberOfComands = 0;
                            break;
                        }
                    }
                    else if (numberComands >= 1 && isCheckDuration)
                    {
                        isCheckDuration = false;
                        numberComands--;
                        Console.WriteLine("Duration {0}. Don't move down", duration);
                        // currentRow--;
                        continue;
                    }

                    for (int col = 1; col < columnLenght; col++)
                    {
                        if (matrix[currentRow, col - 1] >= 0 && matrix[currentRow, col] == 1)
                        {
                            matrix[currentRow, col - 1] = 1;
                            matrix[currentRow, col] = 0;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Right");
                    PrintMatrix(matrix);
                    

                    // check bits in line for bonus                   
                    rowBits = 0;
                    rowBits = GetBitsForBonus(matrix, currentRow, rowBits);
                    isCheckDuration = MoveDown(matrix, currentRow, columnLenght, isCheckDuration);

                    // check full line is bits
                    numberComands = MoveDownAftreEraseRow(columnLenght, numberComands, matrix, currentRow, bonusPoint, isCheckDuration);

                    bonusPoint = GetBonusPoint(matrix, bonusPoint, inputNumber, currentRow, rowBits);
                    if (isCheckDuration)
                    {
                        isCheckDuration = false;
                    }
                    else
                    {
                        currentRow++;
                    }

                    Console.WriteLine("Print after move R <--");
                    Console.WriteLine();
                    Console.WriteLine("Next down after move");
                    PrintMatrix(matrix);
                    if (numberComands > 1)
                    {
                        // continue;
                    }

                }
                else if (duration == "L")
                {
                    // check after the shift to the лleft will we be able to move down
                    isCheckDuration = MoveDown(matrix, currentRow, columnLenght, isCheckDuration);
                    if (isCheckDuration && currentRow == 0)
                    {
                        int checkBits = 0;
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < columnLenght; j++)
                            {
                                if (matrix[i, j] == 1)
                                {
                                    checkBits++;
                                }
                            }
                        }

                        if (checkBits <= columnLenght)
                        {
                            isCheckDuration = false;
                            numberComands--;
                            Console.WriteLine("Duration {0}. Can move left/rigt an down", duration);
                            continue;
                        }

                        totalNumberOfComands = 0;
                        break;
                    }
                    else if (numberComands >= 1 && isCheckDuration)
                    {
                        isCheckDuration = false;
                        numberComands--;
                        Console.WriteLine("Duration {0}. Don't move down", duration);
                        // currentRow--;
                        continue;
                    }

                    for (int col = 7; col >= 0; col--)
                    {
                        if (matrix[currentRow, col + 1] < columnLenght && matrix[currentRow, col] == 1)
                        {
                            matrix[currentRow, col + 1] = 1;
                            matrix[currentRow, col] = 0;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Left");
                    PrintMatrix(matrix);
                    rowBits = 0;
                    rowBits = GetBitsForBonus(matrix, currentRow, rowBits);
                    isCheckDuration = MoveDown(matrix, currentRow, columnLenght, isCheckDuration);
                    bonusPoint = GetBonusPoint(matrix, bonusPoint, inputNumber, currentRow, rowBits);
                    tmpBonusPoint += bonusPoint;
                    if (isCheckDuration)
                    {
                        isCheckDuration = false;
                    }
                    else
                    {
                        currentRow++;
                    }

                    Console.WriteLine("Print after move L -->");
                    Console.WriteLine();
                    Console.WriteLine("Next down after move");
                    PrintMatrix(matrix);
                    if (numberComands > 1)
                    {
                        //continue;
                    }
                }

                numberComands--;
                if (numberComands == 0)
                {
                    if (bonusPoint > 0)
                    {
                        rowAfterBonus = currentRow;
                    }

                    if (rowAfterBonus > 0)
                    {
                        int bits = 0;
                        for (int i = 0; i < rowAfterBonus + 1; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if (matrix[i, j] == 1)
                                {
                                    bits++;
                                }
                            }
                        }

                        resultAfterBonus = bits;
                    }
                    else
                    {
                        result = GetResult(matrix, result, inputNumber, rowAfterBonus);
                        if (tmpResult < result)
                        {
                            tmpResult = result;
                        }
                    }

                    tmpResult += bonusPoint;


                }

                totalNumberOfComands--;

            }


        }

        tmpResult += resultAfterBonus;

        // print matrix
        Console.WriteLine();
        Console.WriteLine("Finale print");
        PrintMatrix(matrix);
        Console.WriteLine(tmpResult);
    }

    private static int GetBitsForBonus(int[,] matrix, int currentRow, int rowBits)
    {
        for (int col = 0; col < 8; col++)
        {
            if (matrix[currentRow, col] == 1)
            {
                rowBits++;
            }
        }
        return rowBits;
    }

    private static int MoveDownAftreEraseRow(int columnLenght, int numberComands, int[,] matrix, int currentRow, int bonusPoint, bool isCheckDuration)
    {
        //if (currentRow < 3)
        //{
        //    currentRow++;
        //}
        int count = 0;
        for (int col = 0; col < columnLenght; col++)
        {
            if (matrix[currentRow, col] == 1)
            {
                count++;
            }
        }

        if (count == 8)
        {
            for (int col = 0; col < columnLenght; col++)
            {
                matrix[currentRow, col] = 0;
            }

            numberComands = 1;
        }

        if (currentRow > 0 && currentRow < 3)
        {
            for (int i = currentRow - 1; i > 0; i--)
            {
                MoveDown(matrix, currentRow, columnLenght, isCheckDuration);
            }
        }

        return numberComands;
    }

    private static bool MoveDown(int[,] matrix, int currentRow, int columnLenght, bool isCheckDuration)
    {
        for (int col = 0; col < columnLenght; col++)
        {
            if (matrix[currentRow, col] == 1 && matrix[currentRow + 1, col] == 1)
            {
                //if (currentRow == 0)
                //{
                //    return numberComands = 0;
                //}
                isCheckDuration = true;
                return isCheckDuration;
            }
        }

        for (int col = 0; col < columnLenght; col++)
        {
            if (matrix[currentRow, col] == 1)
            {
                matrix[currentRow, col] = 0;
                matrix[currentRow + 1, col] = 1;

            }
        }

        return isCheckDuration;
    }

    private static int GetResult(int[,] matrix, int result, int inputNumber, int rowAfterBonus)
    {
        result = 0;

        if (rowAfterBonus != 0)
        {
            return result;
        }
        else
        {
            for (int row = 0; row < 4; row++)
            {
                int rowResult = 0;
                for (int col = 0; col < 8; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        rowResult++;
                    }

                    //if (result == 8)
                    //{
                    //    rowResult = (inputNumber * 10);
                    //}
                }

                result += rowResult;
            }
        }

        return result;
    }

    private static int GetBonusPoint(int[,] matrix, int bonusPoint, int imputNumber, int currentRow, int rowBits)
    {
        int bonus = 0;
        bonusPoint = 0;
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (matrix[row, col] == 1)
                {
                    bonus++;
                }
            }

            if (bonus == 8)
            {
                bonusPoint = rowBits * 10;

                return bonusPoint;
            }
        }
        return bonusPoint;
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    public static int rowAfterBonus
    {
        get;
        set;
    }
}