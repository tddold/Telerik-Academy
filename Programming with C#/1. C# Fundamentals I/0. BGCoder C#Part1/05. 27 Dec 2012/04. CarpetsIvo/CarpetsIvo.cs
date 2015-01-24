using System;

class CarpetsIvo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n;
        int hight = n;

        int[,] matrix = new int[hight, width];

        bool isSlash = true;
        int startSlash = n / 2 - 1;
        int endSlah = n / 2 - 1;

        for (int row = 0; row < hight / 2; row++)
        {
            for (int col = 0; col < width / 2; col++)
            {
                if (startSlash <= col && col <= endSlah)
                {
                    if (isSlash)
                    {
                        matrix[row, col] = 1;
                        matrix[row, n - 1 - col] = 2;
                        matrix[(n-1) - row, col] = 2;
                        matrix[(n - 1) -row, n - 1 - col] = 1;
                        isSlash = false;
                    }
                    else
                    {
                        matrix[row, col] = 3;
                        matrix[row, n - 1 - col] = 3;
                        matrix[(n - 1) - row, col] = 3;
                        matrix[(n - 1) - row, n - 1 - col] = 3;
                        isSlash = true;
                    }
                }
            }

            isSlash = true;
            startSlash--;
        }

        // print
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(".");
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write("/");
                }
                else if (matrix[row, col] == 2)
                {
                    Console.Write("\\");
                }
                else if (matrix[row, col] == 3)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}