using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirinthWithPathStek
{
    class Program
    {
        static string[,] lab =
       {
            {" "," "," ","*"," "," "," ", },
            {"*","*"," ","*"," ","*"," ", },
            {" "," "," "," "," "," "," ", },
            {" ","*","*","*","*","*"," ", },
            {" "," "," "," "," "," ","e", }
        };

        static int count = 0;
        static int index = 0;
        static List<int> path = new List<int>();
        static Stack<int> path1 = new Stack<int>();

        static void Main()
        {
            FindExit(0, 0);
            Console.WriteLine("Found {0} path to exit!", count);
        }

        static void FindExit(int row, int col)
        {
            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                // We are out of the labyrinth -> can't find a path
                return;
            }

            // Check if we have found the exit
            if (lab[row, col] == "e")
            {
                count++;                
                Console.WriteLine("Found the exit!");

                // Print matrix
                PrinPath();
            }

            if (lab[row, col] != " ")
            {
                // The current cell is not free -> can't find a path
                return;
            }

            // Temporary mark the current cell as visited
            index++;
            lab[row, col] = index.ToString();
            path1.Push(index);


            // Invoke recursion to explore all possible directions
            FindExit(row, col - 1); // left
            FindExit(row - 1, col); // up
            FindExit(row, col + 1); // right
            FindExit(row + 1, col); // down

            // Mark back the current cell as free
            lab[row, col] = " ";
            index--;
            path1.Pop();
        }

        private static void PrinPath()
        {
            Console.WriteLine("Path is:");
            foreach (var item in path1)
            {
                Console.Write("{0}, ", path1.Count +1 - item);
            }

            Console.WriteLine("\n{0}",new string('-', 20));
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    Console.Write("{0,3}", lab[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine();
        }
    }
}
