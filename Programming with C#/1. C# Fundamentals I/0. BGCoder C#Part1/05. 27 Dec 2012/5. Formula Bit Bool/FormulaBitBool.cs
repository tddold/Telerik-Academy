using System;

class FormulaBitBool
{
    static void Main()
    {
        bool[,] track = new bool[8, 8];

        for (int i = 0; i < 8; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            for (int j = 0; j < 8; j++)
            {
                track[i, j] = ((currentNumber >> j) & 1) != 0;
            }
        }

        string direction = "down";
        string lastDirection = "down";

        int row = 0;
        int col = 0;

        int pathCount = 0;
        int directionCount = 0;

        bool exitFound = false;


        while (true)
        {           

            if (track[row, col])
            {
                break;
            }

            pathCount++;

            if (row == 7 && col == 7)
            {
                exitFound = true;
                break;
            }

            if (direction == "down" && (row + 1 > 7 || track[row + 1, col]))
            {
                direction = "left";
                lastDirection = "down";
                directionCount++;

                if (col > 7 || track[row, col + 1])
                {
                    break;
                }
            }
            else if (direction == "up" && (row - 1 < 0 || track[row - 1, col]))
            {
                direction = "left";
                lastDirection = "up";
                directionCount++;

                if (col + 1 > 7 || track[row, col + 1])
                {
                    break;
                }
            }
            else if (direction == "left" && lastDirection == "down" && (col + 1 > 7 || track[row, col + 1]) )
            {
                direction = "up";
                directionCount++;

                if (row - 1 < 0 || track[row - 1, col])
                {
                    break;
                }
            }
             else if (direction == "left" && lastDirection == "up" && (col + 1 > 7 || track[row, col + 1]) )
            {
                direction = "down";
                directionCount++;

                if (row + 1 > 7 || track[row + 1, col])
                {
                    break;
                }
            }


            if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col++;
            }
            else if (direction == "up")
            {
                row--;
            }
        }

        if (exitFound)
        {
            Console.WriteLine("{0} {1}", pathCount, directionCount);
        }
        else
        {
            Console.WriteLine("No {0}", pathCount);
        }

        
    }
}