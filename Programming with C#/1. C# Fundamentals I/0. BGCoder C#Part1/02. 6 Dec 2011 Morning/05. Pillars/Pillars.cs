using System;

class Pillars
{
    static void Main()
    {
        int n = 8;

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = (currentNumber >> j) & 1;
            }
        }

        int countLeftSide = 0;
        int countRightSide = 0;        
        int pillarIndex = 7;

        bool isFound = false;

        while (pillarIndex >= 0)
        {
            countLeftSide = 0;
            countRightSide = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < pillarIndex; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        countLeftSide++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = pillarIndex + 1; j < n; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        countRightSide++;
                    }
                }
            }

            if (countLeftSide == countRightSide)
            {
                isFound = true;
                break;
            }

            pillarIndex--;            
        }

        if (isFound)
        {
            Console.WriteLine(pillarIndex);
            Console.WriteLine(countLeftSide);
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}