using System;

namespace Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    int bit = (number >> j)&1;
                    matrix[i, j] = bit;
                }
            }

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
                    else if (longestLine == currentLine)
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
                    else if (longestLine == currentLine)
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
        }
    }
}
