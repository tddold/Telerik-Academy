using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Program
    {
        static void Main()
        {
            bool[,] matrix = new bool[8, 8];
            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    if (((number >> col) & 1) == 1)
                    {
                        matrix[row, col] = true;
                    }

                }
            }

            int pillarIndex = 7;
            int countBitsLeft = 0;
            int countBitsRight = 0;
            bool foundSolution = false;

            while (pillarIndex >= 0)
            {
                countBitsLeft = 0;
                countBitsRight = 0;
                for (int col = 0; col < pillarIndex; col++)
                {
                    for (int row = 0; row < 8; row++)
                    {
                        if (matrix[row, col]) //!!!
                        {
                            countBitsLeft++;
                        }
                    }
                }

                for (int col = pillarIndex + 1; col < 8; col++)
                {
                    for (int row = 0; row < 8; row++)
                    {
                        if (matrix[row, col] == true) //!!!
                        {
                            countBitsRight++;
                        }
                    }
                }

                if (countBitsLeft == countBitsRight)
                {
                    foundSolution = true;
                    break;
                }
                else
                {
                    pillarIndex--;
                }
            }

            if (foundSolution)
            {
                Console.WriteLine(pillarIndex); //!!
                Console.WriteLine(countBitsLeft);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
