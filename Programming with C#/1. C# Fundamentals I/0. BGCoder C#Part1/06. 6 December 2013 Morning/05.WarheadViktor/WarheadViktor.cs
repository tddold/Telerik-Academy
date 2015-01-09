using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WarheadViktor
{
    class WarheadViktor
    {
        static int redRemoved = 0;
        static int blueRemoved = 0;
        static StringBuilder result = new StringBuilder();
        static bool isOver = false;

        static void Main(string[] args)
        {
            char[,] matrix = new char[16, 16];
            ReadInput(matrix);

            string command = Console.ReadLine();
            while (command != "cut")
            {
                switch (command)
                {
                    case "hover":
                        HoverCommand(matrix);
                        break;
                    case "operate":
                        OperateCommand(matrix);
                        break;
                    default:
                        throw new ArgumentException();
                        break;
                }

                if (isOver)
                {
                    Console.WriteLine(result);
                    return;
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            int detonatorsRed = CheckIsRedEmpty(matrix);
            int detonatorsBlue = CheckIsBlueEmpty(matrix);

            if (command == "red")
            {
                if (detonatorsRed > 0)
                {
                    result.AppendLine(detonatorsRed.ToString());
                    result.AppendLine("BOOM");
                }
                else
                {
                    result.AppendLine(detonatorsBlue.ToString());
                    result.AppendLine("disarmed");
                }
            }
            else if (command == "blue")
            {
                if (detonatorsBlue > 0)
                {
                    result.AppendLine(detonatorsBlue.ToString());
                    result.AppendLine("BOOM");
                }
                else
                {
                    result.AppendLine(detonatorsRed.ToString());
                    result.AppendLine("disarmed");
                }
            }

            Console.WriteLine(result);
        }

        private static int CheckIsBlueEmpty(char[,] matrix)
        {
            int shapesLeft = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 8; col < 16; col++)
                {
                    if (CheckIsDetonator(matrix, row, col, matrix.GetLength(0), matrix.GetLength(1)))
                    {
                        shapesLeft++;
                    }
                }
            }

            return shapesLeft;
        }

        private static int CheckIsRedEmpty(char[,] matrix)
        {
            int shapesLeft = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (CheckIsDetonator(matrix, row, col, matrix.GetLength(0), matrix.GetLength(1)))
                    {
                        shapesLeft++;
                    }
                }
            }

            return shapesLeft;
        }

        private static void OperateCommand(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            bool isRedSide = col < 7;

            if (matrix[row, col] == '1')
            {
                result.AppendLine("missed");
                if (isRedSide)
                {
                    result.AppendLine(redRemoved.ToString());
                }
                else
                {
                    result.AppendLine(blueRemoved.ToString());
                }

                result.AppendLine("BOOM");
                isOver = true;
            }
            else
            {
                bool isDetonatorMiddle = CheckIsDetonator(matrix, row, col, rows, cols);


                if (isDetonatorMiddle)
                {
                    if (isRedSide)
                    {
                        redRemoved++;
                    }
                    else
                    {
                        blueRemoved++;
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        matrix[row + i - 1, col - 1] = '0';
                        matrix[row + i - 1, col + 1] = '0';
                        matrix[row + 1, col + i - 1] = '0';
                        matrix[row - 1, col + i - 1] = '0';
                    }
                }
            }
        }

        private static bool CheckIsDetonator(char[,] matrix, int row, int col, int rows, int cols)
        {

            for (int i = 0; i < 3; i++)
            {
                if ((row + i - 1 < 0|| row + i - 1 >= rows || col + i - 1 < 0 || col + i - 1 >= cols || col - 1 < 0 ||
                       col + 1 >= cols|| row - 1 < 0 || row + 1 >= rows))
                {
                    return false;
                }

                if ((matrix[row + i - 1, col - 1] != '1' ||
                        matrix[row + i - 1, col + 1] != '1' ||
                        matrix[row + 1, col + i - 1] != '1' ||
                        matrix[row - 1, col + i - 1] != '1'))
                {
                    return false;
                }
            }

            return true;
        }

        private static void HoverCommand(char[,] matrix)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            if (matrix[row, col] == '0')
            {
                result.AppendLine("-");
            }
            else
            {
                result.AppendLine("*");
            }
        }

        private static void ReadInput(char[,] matrix)
        {
            for (int row = 0; row < 16; row++)
            {
                string currentLine = Console.ReadLine();
                for (int col = 0; col < 16; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }
        }
    }
}
