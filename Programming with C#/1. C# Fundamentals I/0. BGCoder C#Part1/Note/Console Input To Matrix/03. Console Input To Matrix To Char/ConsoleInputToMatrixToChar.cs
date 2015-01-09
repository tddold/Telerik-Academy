using System;
using System.Collections.Generic;

class ConsoleInputToMatrixToChar
{
    static void Main()
    {
        int n = 16;
        char[,] matrix = new char[n, n];

        /*
         * Input                                         Output
         *  0000000000000111                          cookie crumb
            0100000000000111                          broken cookie
            0000000000000111                          cookie
            0000000000000000                          page
            0000000000000000                          smile
            0000000000000000                          1.79
            0000000000000000
            0000000000000000
            0000000000000000
            0000000000000000
            0000000000000000
            0000000000000000
            0000000000000000
            0000000000000000
            0000000000000000
            0000000000000000
            what is
            1
            1
            what is
            0
            14
            what is
            1
            14
            buy
            1
            1
            buy
            1
            14
            what is
            0
            14
            paypal
         */

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
        

        // output
        Console.WriteLine();


        Console.WriteLine("Here is input!");
        PrintMatrix(matrix);
        PrintCommands(commands);
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