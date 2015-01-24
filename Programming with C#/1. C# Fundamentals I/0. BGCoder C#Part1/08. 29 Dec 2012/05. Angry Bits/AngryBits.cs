using System;
using System.IO;

class AngryBits
{
    const int width = 16;
    const int hight = 8;
    static void Main()
    {
        // http://bgcoder.com/Contests/Practice/Index/43#4

        //if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
        //{
        //    Console.SetIn(new StreamReader("input.txt"));
        //}

        int[,] matrix = new int[hight, width];

        for (int row = 0; row < hight; row++)
        {
            int input = int.Parse(Console.ReadLine());

            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = (input >> col) & 1;
            }
        }

        //solution
        int flithLenght = 0;
        int destroyedPig = 0;
        int result = 0;
        int pigBits = 0;
        bool isDestroy = false;
        int starDestroyRow = 0;
        int endDestroyRow = 0;
        int starDestroyCol = 0;
        int endDestroyCol = 0;
        // bool isDowan = false;
        bool isUp = true;

        // PrintMatrix(matrix);
        // searsh birds
        for (int col = 8; col < width; col++)
        {
            for (int row = 0; row < hight; row++)
            {
                isUp = true;
                flithLenght = 0;
                if (matrix[row, col] == 1)
                {
                    int currRow = row;
                    int currCol = col;

                    while (currRow >= 0 && isUp) // move up
                    {
                        flithLenght++;
                        if (matrix[currRow, currCol] == 1 && currCol <= 7)
                        {
                            CheckOutOfRangeForDestroy(ref starDestroyRow, ref endDestroyRow, ref starDestroyCol, ref endDestroyCol, currRow, currCol);

                            // destroy
                            for (int i = starDestroyRow; i <= endDestroyRow; i++)
                            {
                                for (int j = starDestroyCol; j <= endDestroyCol; j++)
                                {
                                    isDestroy = true;
                                    if (matrix[i, j] == 1)
                                    {
                                        matrix[i, j] = 0;
                                        destroyedPig++;
                                    }
                                }
                            }

                            if (isDestroy)
                            {
                                result += (flithLenght - 1) * destroyedPig;
                                destroyedPig = 0;
                                flithLenght = 0;
                                break;
                            }
                            else if (currRow == hight - 1 || currCol == 0)
                            {
                                flithLenght = 0;
                                break;
                            }
                            else if (currRow == 0)
                            {
                                isUp = false;
                                flithLenght--;
                                break;
                            }
                        }

                        currRow--;
                        currCol--;

                    }

                    currRow++;
                    currCol++;
                    flithLenght--;

                    if (currRow == 0) // move dowan
                    {
                        while (currRow <= hight - 1 && currCol >= 0)
                        {
                            flithLenght++;
                            if (matrix[currRow, currCol] == 1 && currCol <= 7)
                            {
                                CheckOutOfRangeForDestroy(ref starDestroyRow, ref endDestroyRow, ref starDestroyCol, ref endDestroyCol, currRow, currCol);

                                // destroy
                                for (int i = starDestroyRow; i <= endDestroyRow; i++)
                                {
                                    for (int j = starDestroyCol; j <= endDestroyCol; j++)
                                    {
                                        isDestroy = true;
                                        if (matrix[i, j] == 1)
                                        {
                                            matrix[i, j] = 0;
                                            destroyedPig++;
                                        }
                                    }
                                }

                                if (isDestroy)
                                {
                                    result += (flithLenght - 1) * destroyedPig;
                                    destroyedPig = 0;
                                    flithLenght = 0;
                                    break;
                                }
                                else if (currRow == hight - 1 || currCol == 0)
                                {
                                    flithLenght = 0;
                                    break;
                                }
                            }

                            currRow++;
                            currCol--;
                        }
                    }

                    //Console.WriteLine();
                    //PrintMatrix(matrix);
                }
            }
        }

        // checking for win
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (matrix[row, col] == 1)
                {
                    pigBits++;
                }
            }
        }


        // print
        //PrintMatrix(matrix);
        if (pigBits != 0)
        {
            Console.WriteLine("{0} No", result);
        }
        else
        {
            Console.WriteLine("{0} Yes", result);
        }

    }

    private static void CheckOutOfRangeForDestroy(ref int starDestroyRow, ref int endDestroyRow, ref int starDestroyCol, ref int endDestroyCol, int currRow, int currCol)
    {
        if (currRow == 0)
        {
            starDestroyRow = 0;
            endDestroyRow = currRow + 1;
        }
        else if (currRow == hight - 1)
        {
            starDestroyRow = currRow - 1;
            endDestroyRow = hight - 1;
        }
        else
        {
            starDestroyRow = currRow - 1;
            endDestroyRow = currRow + 1;
        }

        if (currCol == 0)
        {
            starDestroyCol = 0;
            endDestroyCol = currCol + 1;
        }
        else if (currCol == 7)
        {
            starDestroyCol = currCol - 1;
            endDestroyCol = 7;
        }
        else
        {
            starDestroyCol = currCol - 1;
            endDestroyCol = currCol + 1;
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}