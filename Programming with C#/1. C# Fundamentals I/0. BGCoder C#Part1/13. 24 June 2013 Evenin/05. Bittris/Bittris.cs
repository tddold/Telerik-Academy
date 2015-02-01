using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.Bittris
{
    class Bittris
    {
        const int matrixRow = 4;
        const int matrixCol = 24;
        const int shapeCol = 8;
        const int oprations = 3;

        static void Main()
        {
            //StreamReader reader = new StreamReader("..\\..\\input.txt");
            //Console.SetIn(reader);

            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixRow, matrixCol];

            int score = 0;
            int bonusScore = 0;
            int lastInputShapeBits = 0;
            string lastCommands = String.Empty;


            for (int i = 0; i < n / 4; i++)
            {
                int row = 0;
                int inputBits = 0;
                int inputShapeBits = 0;                
                int bonusBits = 0;
                int rowBonus = 0;
                bool isBonus = false;
                bool isDown = true;

                // read number
                int number = int.Parse(Console.ReadLine());

                for (int col = 0; col < matrixCol; col++)
                {
                    matrix[row, col] = (number >> col) & 1;

                    if (matrix[row, col] == 1)
                    {
                        inputBits++;

                        if (col < 8)
                        {
                            inputShapeBits++;
                        }
                    }
                }
                string commands = String.Empty;

                // print matrix
                // PrintMatrix(matrix, commands, number);

                for (int j = 0; j < oprations; j++)
                {
                    // read commands
                    commands = Console.ReadLine();

                    int countBits = inputShapeBits;

                    if (commands == "D")
                    {
                        #region
                        // check for bonus
                        for (int col = 0; col < shapeCol; col++)
                        {

                            if (matrix[row, col] == 1)
                            {
                                bonusBits++;
                            }
                        }

                        if (bonusBits == shapeCol)
                        {
                            for (int col = 0; col < shapeCol; col++)
                            {
                                matrix[row, col] = 0;
                            }

                            // print matrix
                            // PrintMatrix(matrix, commands, number);

                            //while (j > 0)
                            //{
                            //    commands = Console.ReadLine();
                            //    j--;
                            //}

                            isBonus = true;
                            row = 0;
                            bonusBits = 0;
                            // break;
                        }

                        isDown = true;

                        // check for move Down
                        for (int col = 0; col < shapeCol; col++)
                        {
                            if (row < matrixRow - 1 && matrix[row, col] == 1 && countBits > 0)
                            {
                                if (matrix[row + 1, col] == 1)
                                {
                                    isDown = false;
                                    break;
                                }

                                countBits--;
                            }
                        }

                        if (j < 2 && lastCommands == "D" && !isDown)
                        {
                            commands = Console.ReadLine();
                            break;
                        }

                        // move Down
                        if (isDown)
                        {
                            for (int col = 0; col < shapeCol; col++)
                            {
                                if (matrix[row, col] == 1)
                                {
                                    matrix[row, col] = 0;
                                    matrix[row + 1, col] = 1;
                                }
                            }

                            row++;
                        }

                        lastCommands = commands;

                        // print matrix
                        // PrintMatrix(matrix, commands, number);
                        #endregion
                    }
                    else if (commands == "R")
                    {
                        #region
                        // check for bonus
                        for (int col = 0; col < shapeCol; col++)
                        {
                            if (row == 0)
                            {
                                if (row == matrixRow - 1 || matrix[matrixRow - 1, col] != 1)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (matrix[row + 1, col] != 1)
                                {
                                    break;
                                }
                            }

                            bonusBits++;


                        }

                        if (bonusBits == shapeCol)
                        {
                            for (int col = 0; col < shapeCol; col++)
                            {
                                if (row == 0)
                                {
                                    matrix[matrixRow - 1, col] = 0;
                                    rowBonus = matrixRow - 1;
                                }
                                else
                                {
                                    matrix[row + 1, col] = 0;                                    
                                }


                                if (matrix[row, col] == 1)
                                {
                                    matrix[row, col] = 0;
                                    matrix[row + 1, col] = 1;
                                }
                            }

                            // print matrix
                            // PrintMatrix(matrix, commands, number);

                            //while (j > 0)
                            //{
                            //    commands = Console.ReadLine();
                            //    j--;
                            //}

                            isBonus = true;                            
                            row++;
                            bonusBits = 0;
                            // break;
                        }

                        isDown = true;

                        // check for move Right
                        bool isRight = true;

                        if (matrix[row, 0] == 1)
                        {
                            isRight = false;
                        }

                        // move Right
                        if (isRight)
                        {
                            for (int col = 1; col < shapeCol; col++)
                            {
                                if (matrix[row, col] == 1)
                                {
                                    matrix[row, col] = 0;
                                    matrix[row, col - 1] = 1;
                                }
                            }
                        }
                        // print matrix
                        // PrintMatrix(matrix, commands, number);

                        // check for move Down
                        for (int col = 0; col < shapeCol; col++)
                        {
                            if (row < matrixRow - 1 && matrix[row, col] == 1 && countBits > 0)
                            {
                                if (matrix[row + 1, col] == 1)
                                {
                                    isDown = false;
                                    break;
                                }

                                countBits--;
                            }
                        }

                        // move Down
                        if (isDown)
                        {
                            for (int col = 0; col < shapeCol; col++)
                            {
                                if (matrix[row, col] == 1)
                                {
                                    matrix[row, col] = 0;
                                    matrix[row + 1, col] = 1;
                                }
                            }

                            row++;
                        }

                        lastCommands = commands;

                        // print matrix
                        // PrintMatrix(matrix, commands, number);
                        #endregion
                    }                        
                    else if (commands == "L")
                    {
                        // check for bonus
                        for (int col = 0; col < shapeCol; col++)
                        {
                            if (row == 0)
                            {
                                if (matrix[matrixRow - 1, col] != 1)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (row == matrixRow - 1 || matrix[row + 1, col] != 1)
                                {
                                    break;
                                }
                            }

                            bonusBits++;
                        }

                        if (bonusBits == shapeCol)
                        {
                            for (int col = 0; col < shapeCol; col++)
                            {
                                if (row == 0)
                                {
                                    matrix[matrixRow - 1, col] = 0;
                                    rowBonus = matrixRow - 1;
                                }
                                else
                                {
                                    matrix[row + 1, col] = 0;
                                }

                                if (matrix[row, col] == 1)
                                {
                                    matrix[row, col] = 0;
                                    matrix[row + 1, col] = 1;
                                }
                            }

                            // print matrix
                            // PrintMatrix(matrix, commands, number);

                            //while (j > 0)
                            //{
                            //    commands = Console.ReadLine();
                            //    j--;
                            //}

                            isBonus = true;
                            row++;
                            bonusBits = 0;
                            // break;
                        }

                        isDown = true;

                        // check for move Left
                        bool isLeft = true;

                        if (row == matrixRow -1)
                        {
                            continue;
                        }

                        if (matrix[row, shapeCol - 1] == 1)
                        {
                            isLeft = false;
                        }

                        // move Left
                        if (isLeft)
                        {
                            for (int col = shapeCol - 1; col >= 0; col--)
                            {
                                if (matrix[row, col] == 1)
                                {
                                    matrix[row, col] = 0;
                                    matrix[row, col + 1] = 1;
                                }
                            }
                        }

                        // check for move Down
                        for (int col = 0; col < shapeCol; col++)
                        {
                            if (row < matrixRow - 1 && matrix[row, col] == 1 && countBits > 0)
                            {
                                if (matrix[row + 1, col] == 1)
                                {
                                    isDown = false;
                                    break;
                                }

                                countBits--;
                            }
                        }

                        // move Down
                        if (isDown)
                        {
                            for (int col = 0; col < shapeCol; col++)
                            {
                                if (matrix[row, col] == 1)
                                {
                                    matrix[row, col] = 0;
                                    matrix[row + 1, col] = 1;
                                }
                            }

                            row++;
                        }

                        lastCommands = commands;
                        

                        // print matrix
                        // PrintMatrix(matrix, commands, number);
                    }
                }                

                if (isBonus)
                {
                    if (rowBonus == matrixRow - 1)
                    {
                        score += (lastInputShapeBits * 10) - lastInputShapeBits + inputBits;                        
                    }
                    else
                    {
                        score += inputBits * 10;
                    }

                    isBonus = false;
                   
                }
                else
                {
                    score += inputBits;
                }

                lastInputShapeBits = inputShapeBits;

                // print score
                // Console.WriteLine("Score = {0}", score);
            }

            Console.WriteLine(score);
        }

        private static void PrintMatrix(int[,] matrix, string commands, int number)
        {
            Console.Write(number);
            Console.WriteLine(commands);

            for (int row = 0; row < matrixRow; row++)
            {
                for (int col = 0; col < shapeCol; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
