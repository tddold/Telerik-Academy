using System;

class Lines
{
    static void Main()
    {
        // inicialization
        int n = 8;
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            int currenNumber = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = (currenNumber >> j) & 1;
            }
        }

        // logic
        int longestLine = 0;
        int longestCount = 0;

        for (int i = 0; i < n; i++)
        {
            int currentLine = 0;
            for (int j = 0; j < n; j++)
            {
                while (j < n && matrix[i, j] == 1)
                {
                    currentLine++;
                    j++;
                }

                if (currentLine > longestLine)
                {
                    longestLine = currentLine;
                    longestCount = 1;
                }
                else if (currentLine == longestLine)
                {
                    longestCount++;
                }
                currentLine = 0;
            }
        }

        for (int j = 0; j < n; j++)
        {
            int currentLine = 0;
            for (int i = 0; i < n; i++)
            {
                while (i < n && matrix[i, j] == 1)
                {
                    currentLine++;
                    i++;
                }

                if (currentLine > longestLine)
                {
                    longestLine = currentLine;
                    longestCount = 1;
                }
                else if (currentLine == longestLine)
                {
                    longestCount++;
                }

                currentLine = 0;
            }
        }

        if (longestLine == 1)
        {
            longestCount = longestCount / 2;
        }

        Console.WriteLine(longestLine);
        Console.WriteLine(longestCount);

        //// print matrix
        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j < 8; j++)
        //    {
        //        Console.Write(matrix[i, j]);
        //    }

        //    Console.WriteLine();
        //}
    }
}