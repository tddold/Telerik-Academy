
using System;
using System.Collections.Generic;
using System.Text;

class GameOfPageWithMethods
{
    static void Main()
    {
        int n = 16;
        char[,] matrix = new char[n, n];

        // input
        for (int row = 0; row < n; row++)
        {
            string numToString = Console.ReadLine();
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = numToString[col];
            }
        }

        List<string> commands = new List<string>();

        while (true)
        {
            commands.Add(Console.ReadLine());
            if (commands[commands.Count - 1] == "paypal")
            {
                break;
            }
        }

        // Solution
        double cost = 1.79;
        int countCookie = 0;
        string smile = "smile";
        string page = "page";
        string cookieCrumb = "cookie crumb";
        string brokenCookie = "broken cookie";
        string cookie = "cookie";
        int line = 0;
        int column = 0;

        for (int k = 0; k < commands.Count; k = k + 3)
        {
            if (commands[k] == "what is")
            {
                line = int.Parse(commands[k + 1]);
                column = int.Parse(commands[k + 2]);

                if (matrix[line, column] == '1')
                {
                    int countBits = 0;
                    if ((line == 0 || line == 15) && (column != 0 && column != 15))
                    {
                        for (int j = column - 1; j <= column + 1; j++)
                        {
                            if (matrix[line, j] == '1')
                            {
                                countBits++;
                            }

                        }
                    }
                    else if ((column == 0 || column == 15) && (line != 0 && line != 15))
                    {
                        for (int i = line - 1; i <= line + 1; i++)
                        {
                            if (matrix[i, column] == '1')
                            {
                                countBits++;
                            }

                        }
                    }
                    else if (line == 0 && column == 0)
                    {
                        for (int i = line; i <= line + 1; i++)
                        {

                            for (int j = column; j <= column + 1; j++)
                            {
                                if (matrix[i, j] == '1')
                                {
                                    countBits++;
                                }
                            }
                        }
                    }
                    else if (line == 0 && column == 15)
                    {
                        for (int i = line; i <= line + 1; i++)
                        {

                            for (int j = column - 1; j <= column; j++)
                            {
                                if (matrix[i, j] == '1')
                                {
                                    countBits++;
                                }
                            }
                        }
                    }
                    else if (line == 15 && column == 0)
                    {
                        for (int i = line - 1; i <= line; i++)
                        {

                            for (int j = column; j <= column + 1; j++)
                            {
                                if (matrix[i, j] == '1')
                                {
                                    countBits++;
                                }
                            }
                        }
                    }
                    else if (line == 15 && column == 15)
                    {
                        for (int i = line - 1; i <= line; i++)
                        {

                            for (int j = column - 1; j <= column; j++)
                            {
                                if (matrix[i, j] == '1')
                                {
                                    countBits++;
                                }
                            }
                        }
                    }
                    else
                    {
                        countBits = CheckAndCountBitsInMatrix(matrix, line, column, countBits);
                    }

                    if (countBits == 9)
                    {
                        Console.WriteLine(cookie);
                    }
                    else if (1 < countBits && countBits < 9)
                    {
                        Console.WriteLine(brokenCookie);
                    }
                    else if (countBits == 1)
                    {
                        Console.WriteLine(cookieCrumb);
                    }
                }
                else
                {
                    Console.WriteLine(smile);
                }
            }
            else if (commands[k] == "buy")
            {
                line = int.Parse(commands[k + 1]);
                column = int.Parse(commands[k + 2]);
                if (matrix[line, column] == '1')
                {
                    int countBits = 0;
                    if (line != 0 && line != 15 && column != 0 && column != 15)
                    {
                        for (int i = line - 1; i <= line + 1; i++)
                        {
                            for (int j = column - 1; j <= column + 1; j++)
                            {
                                if (matrix[i, j] == '1')
                                {
                                    countBits++;
                                }
                            }
                        }

                        if (countBits == 9)
                        {
                            countCookie++;
                            for (int i = line - 1; i <= line + 1; i++)
                            {
                                for (int j = column - 1; j <= column + 1; j++)
                                {
                                    matrix[i, j] = '0';
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(page);
                        }
                    }
                    else
                    {
                        Console.WriteLine(page);
                    }
                }
                else
                {
                    Console.WriteLine(page);
                }
            }
            else if (commands[k] == "paypal")
            {
                break;
            }
        }

        // output
        Console.WriteLine("{0:0.00}", countCookie * cost);



        // PrintMatrix(matrix);
        // PrintCommands(commands);
    }

    private static int CheckAndCountBitsInMatrix(char[,] matrix, int line, int column, int countBits)
    {
        
        for (int i = line - 1; i <= line + 1; i++)
        {

            for (int j = column - 1; j <= column + 1; j++)
            {
                if (matrix[i, j] == '1')
                {
                    countBits++;
                }
            }
        }
        return countBits;
    }

    private static void PrintCommands(List<string> commands)
    {
        for (int i = 0; i < commands.Count; i++)
        {
            Console.WriteLine(commands[i]);
        }
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
        {
            for (int col1 = 0; col1 < matrix.GetLength(1); col1++)
            {
                Console.Write(matrix[row1, col1] + " ");
            }
            Console.WriteLine();
        }
    }
}