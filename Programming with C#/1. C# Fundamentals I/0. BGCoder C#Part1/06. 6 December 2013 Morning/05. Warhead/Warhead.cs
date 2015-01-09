using System;
using System.Collections.Generic;

class Warhead
{
    static void Main()
    {
        int n = 16;
        char[,] matrix = new char[n, n];

        for (int row = 0; row < n; row++)
        {
            string input = Console.ReadLine();
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = input[col];
            }
        }

        List<string> commands = new List<string>();

        while (true)
        {
            commands.Add(Console.ReadLine());

            //if (commands[commands.Count - 1] == " ")
            //{
            //    commands.Remove(" ");
            //    break;
            //}


        }

        PrintMatrix(matrix);
        PrintCOmmands(commands);
    }

    private static void PrintCOmmands(List<string> commands)
    {
        for (int i = 0; i < commands.Count; i++)
        {
            Console.WriteLine( commands[i]);
        }
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}