using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Bit_Ball
{
    class BitBall
    {
        static void Main(string[] args)
        {
            string[] input = new string[16];
            char[,] matrix = new char[8, 8];
            for (int i = 0; i < 16; i++)
            {
                input[i] = Console.ReadLine();
            }

            ReadMatrix(matrix, input);

            string[] topPlayers = new string[8];
            string[] bottomPlayers = new string[8];
            for (int i = 0; i < input.Length / 2; i++)
            {
                int topTeam = int.Parse(input[i]);
                int bottomTeam = int.Parse(input[8 + i]);

                char[] rowTopTeam = Convert.ToString(topTeam, 2).PadLeft(8, '0').ToCharArray();
                char[] rowBottomTeam = Convert.ToString(bottomTeam, 2).PadLeft(8, '0').ToCharArray();


                for (int j = 0; j < rowTopTeam.Length; j++)
                {
                    if (rowTopTeam[j] == rowBottomTeam[j])
                    {
                        rowTopTeam[j] = '0';
                        rowBottomTeam[j] = '0';
                    }
                }

                topPlayers[i] = new string(rowTopTeam);
                bottomPlayers[i] = new string(rowBottomTeam);
            }

            int goalsTop = 0;
            int goalsBottom = 0;

            //PrintMatrix(matrix);

            //Console.WriteLine(string.Join("\n", topPlayers));
            //Console.WriteLine();
            //Console.WriteLine(string.Join("\n", bottomPlayers));

            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (topPlayers[row][col] == '1')
                    {
                        if (row == 7)
                        {
                            goalsTop++;
                        }
                        for (int rowBottom = row + 1; rowBottom < 8; rowBottom++)
                        {
                            if (bottomPlayers[rowBottom][col] != '0' || topPlayers[rowBottom][col] != '0')
                            {
                                break;
                            }
                            else
                            {
                                if (rowBottom == (bottomPlayers[col].Length - 1))
                                {
                                    goalsTop++;
                                }

                            }
                        }
                    }
                }
            }


            for (int col = bottomPlayers.Length - 1; col >= 0; col--)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (bottomPlayers[row][col] == '1')
                    {
                        if (row == 0)
                        {
                            goalsBottom++;
                        }
                        for (int rowTop = row - 1; rowTop >= 0; rowTop--)
                        {
                            if (topPlayers[rowTop][col] != '0' || bottomPlayers[rowTop][col] != '0')
                            {
                                break;
                            }
                            else
                            {
                                if (rowTop == 0)
                                {
                                    goalsBottom++;
                                }

                            }
                        }
                    }
                }
            }

            Console.WriteLine("{0}:{1}", goalsTop, goalsBottom);

        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != '\0')
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(char[,] matrix, string[] input)
        {
            int count = input.Length;
            int index = 0;
            for (int row = 0; row < input.Length; row++, index++)
            {
                if (index == 8)
                {
                    index = 0;
                }

                int currentLineNumber = int.Parse(input[row]);

                char[] currentLine = Convert.ToString(currentLineNumber, 2).PadLeft(8, '0').ToCharArray();
                for (int col = 0; col < currentLine.Length; col++)
                {
                    if (matrix[index, col] != '\0' && currentLine[col] == '1')
                    {
                        matrix[index, col] = '0';
                    }
                    else if (currentLine[col] == '1')
                    {
                        if (row < input.Length / 2)
                        {
                            matrix[index, col] = 'T';
                        }
                        else
                        {
                            matrix[index, col] = 'B';
                        }
                    }
                }
            }
        }
    }
}
