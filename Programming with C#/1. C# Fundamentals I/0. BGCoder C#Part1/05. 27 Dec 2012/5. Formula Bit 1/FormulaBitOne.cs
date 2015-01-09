using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Formula_Bit_1
{
    class FormulaBitOne
    {
        static void Main(string[] args)
        {
            int constant = 8;
            int currentLineNumber;
            char[,] inputMatrix = new char[constant, constant];

            for (int row = 0; row < constant; row++)
            {
                currentLineNumber = int.Parse(Console.ReadLine());
                char[] currentLine = Convert.ToString(currentLineNumber, 2).PadLeft(8, '0').ToCharArray();

                int index = 0;
                for (int col = 0; col < constant; col++, index++)
                {
                    inputMatrix[row, col] = currentLine[col];
                }
            }

            PrintMtrix(inputMatrix);

            int rowPos = 0;
            int colPos = 7;
            int countDirection = 0;
            int counterLenght = 0;
            bool down = true;
            bool left = false;
            bool top = false;
            bool isTrue = true;
            bool isDirection = true;
            bool isBuild = true;

            while (isTrue)
            {
                if (inputMatrix[rowPos, colPos] == '1')
                {
                    isBuild = false;
                    isTrue = false;
                    break;
                }
                // go down
                if (down)
                {
                    isDirection = true;

                    for (int row = rowPos; row < inputMatrix.GetLength(0); row++)
                    {
                        if (inputMatrix[row, colPos] != '1' && row >= 0)
                        {
                            counterLenght++;
                        }
                        else
                        {
                            left = true;
                            down = false;
                            countDirection++;
                            rowPos = row - 1;
                            colPos = colPos - 1;

                            if (inputMatrix[rowPos, colPos] == '1')
                            {
                                isBuild = false;
                                isTrue = false;
                            }

                            break;
                        }

                        if (row == constant - 1)
                        {
                            if (colPos == 0)
                            {
                                isTrue = false;
                                break;
                            }

                            if (inputMatrix[row, colPos - 1] == '1')
                            {
                                isTrue = false;
                                break;
                            }
                            else
                            {
                                left = true;
                                down = false;
                                countDirection++;
                                rowPos = row - 1;
                                colPos = colPos - 1;
                                if (inputMatrix[rowPos, colPos] == '1')
                                {
                                    isBuild = false;
                                    isTrue = false;
                                    break;
                                }
                                break;
                            }
                        }
                    }
                }


                // go left
                if (left)
                {
                    for (int col = colPos; col >= 0; col--)
                    {
                        if (inputMatrix[rowPos, col] != '1' && col >= 0)
                        {
                            counterLenght++;
                        }
                        else
                        {
                            if (isDirection)
                            {
                                top = true;
                            }
                            else
                            {
                                down = true;
                            }

                            left = false;
                            countDirection++;
                            colPos = col + 1;
                            if (inputMatrix[rowPos - 1, colPos] == '1' && top)
                            {
                                isBuild = false;
                                isTrue = false;
                                break;
                            }

                            if (inputMatrix[rowPos + 1, colPos] == '1' && down)
                            {
                                isBuild = false;
                                isTrue = false;
                                break;
                            }
                            break;
                        }

                        if (col == 0)
                        {
                            if (inputMatrix[rowPos + 1, col] == '1')
                            {
                                isBuild = false;
                                isTrue = false;
                                break;
                            }
                            else
                            {
                                if (isDirection)
                                {
                                    top = true;
                                }
                                else
                                {
                                    down = true;
                                }

                                left = false;
                                countDirection++;
                                colPos = col;
                                rowPos = rowPos + 1;
                                if (inputMatrix[rowPos, colPos] == '1')
                                {
                                    isBuild = false;
                                    isTrue = false;
                                    break;
                                }
                                break;
                            }
                        }
                    }
                }

                // go top
                if (top)
                {
                    isDirection = false;

                    for (int row = rowPos - 1; row >= 0; row--)
                    {
                        if (inputMatrix[row, colPos] != '1' && row >= 0)
                        {
                            counterLenght++;
                        }
                        else
                        {
                            left = true;
                            top = false;
                            countDirection++;
                            rowPos = row;
                            colPos = colPos - 1;
                            break;
                        }

                        if (row == 0)
                        {
                            if (inputMatrix[row, colPos - 1] == '1')
                            {
                                isTrue = false;
                                break;
                            }
                            else
                            {
                                left = true;
                                top = false;
                                countDirection++;
                                rowPos = row;
                                colPos = colPos - 1;
                                if (inputMatrix[rowPos, colPos] == '1')
                                {
                                    isBuild = false;
                                    isTrue = false;
                                    break;
                                }
                                break;
                            }
                        }

                        //if (inputMatrix[constant - 1, 0] == '0')
                        //{
                        //    isTrue = false;
                        //    break;
                        //}
                        //else
                        //{
                        //    isBuild = false;
                        //    isTrue = false;
                        //    break;
                        //}
                    }
                }
            }

            if (isBuild)
            {
                Console.WriteLine("{0} {1}", counterLenght, countDirection);
            }
            else
            {
                Console.WriteLine("No {0}", counterLenght);
            }

        }

        private static void PrintMtrix(char[,] inputMatrix)
        {
            for (int row = 0; row < inputMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", inputMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
