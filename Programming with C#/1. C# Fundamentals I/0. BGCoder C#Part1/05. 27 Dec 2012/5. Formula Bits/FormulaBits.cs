using System;

class FormulaBits
{
    static void Main()
    {
        int[,] track = new int[8, 8];

        string direction = "down";

        for (int i = 0; i < 8; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            for (int j = 0; j < 8; j++)
            {
                track[i, j] = (currentNumber >> j) & 1;
                
            }
        }

        int row = 0;
        int col = 0;

        int pathTrack = 0;
        int directionCount = 0;

        bool exitFound = false;
        string isDirection = "down";

        while (true)
        {            

            if (track[0, 0] == 1)
            {
                break;
            }

            if (direction =="down" && (row > 7 || track[row, col] == 1))
            {
                row--;
                col++;
                direction = "left";
                isDirection = "down";
                directionCount++;

                if (col > 7 || track[row, col] == 1)
                {
                    break;
                }
            }
            else if(direction == "left" && (col > 7 || track[row, col] == 1))
            {
                
                directionCount++;

                if (isDirection == "down")
                {
                    row--;
                    col--;
                     direction = "up";
                }
                else
                {
                    row++;
                    col--;
                    direction = "down";
                }

                if (row < 0 || track[row, col] == 1)
                {
                    break;
                }
            }
            else if (direction == "up" && (row < 0 || track[row, col] == 1))
            {
                row++;
                col++;
                direction = "left";
                isDirection = "up";
                directionCount++;

                if (col > 7 || track[row, col] == 1)
                {
                    break;  
                }
            }

            pathTrack++;            

            if (row == 7 && col == 7)
            {
                exitFound = true;
                break;
            }
            else if (direction == "down")
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
            Console.WriteLine("{0} {1}", pathTrack, directionCount);
        }
        else
        {
            Console.WriteLine("No {0}", pathTrack);
        }

        //// print matrix
        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j < 8; j++)
        //    {
        //        Console.Write(track[i, j]);
        //    }

        //    Console.WriteLine();
        //}
    }
}