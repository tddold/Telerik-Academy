namespace RotatingWalkInMatrix
{
    using System;
    public class RotatingWalkInMatrix
    {        
        static void Main()
        {
            byte matrixSize = ReadInput();
            var generatedMatrix = Matrix.GenerrateMatrix(matrixSize);
            PrintMatrix(generatedMatrix);
        }

        private static byte ReadInput()
        {
            Console.Write("Enter a positive number: ");
            string input = Console.ReadLine();

            byte n;
            while (!byte.TryParse(input, out n) || n <= 0 || n > 100)
            {
                Console.WriteLine(" - Invalid input: You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            return n;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write("{0,3}", matrix[row, column]);
                }

                Console.WriteLine();
            }
        }
    }
}
