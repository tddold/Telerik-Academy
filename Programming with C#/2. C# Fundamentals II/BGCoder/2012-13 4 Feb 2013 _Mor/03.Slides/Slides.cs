using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Slides
{
    class Slides
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int cuboidWidth = int.Parse(line[0]);
            int cuboidHeigth = int.Parse(line[1]);
            int cuboidDepth = int.Parse(line[2]);

            // read cuboid
            string[, ,] cuboid = new string[cuboidWidth, cuboidHeigth, cuboidDepth];
            for (int h = 0; h < cuboidHeigth; h++)
            {
                string[] row = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                for (int d = 0; d < cuboidDepth; d++)
                {
                    string[] cubes = row[d].Trim().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int w = 0; w< cuboidWidth; w++)
                    {
                        string cube = cubes[w];
                        cuboid[w, h, d] = cube;
                    }
                }
            }

            // read ball
            line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int ballWidth = 0;
            int ballHeigth = 0;
            int ballDepth = 0;

            // calc
            bool canDrop = true;
            int nextWidth = int.Parse(line[0]);
            int nextHeigth = 0;
            int nextDepth = int.Parse(line[1]);
            string currCube = string.Empty;

            while (canDrop)
            {
                if (nextHeigth == cuboidHeigth)
                {
                    break;
                }

                if (nextWidth < 0 || nextWidth > cuboidWidth - 1 ||
                    nextDepth < 0 || nextDepth > cuboidDepth - 1)
                {
                    canDrop = false;
                    break;
                }

                ballWidth = nextWidth;
                ballHeigth = nextHeigth;
                ballDepth = nextDepth;

                // read current cube
                currCube = cuboid[nextWidth, nextHeigth, nextDepth];

                // read current comand
                // S X; T 1 1; B; E

                char command = currCube[0];
                switch (command)
                {
                    case 'B':
                        canDrop = false;
                        break;
                    case 'E':
                        nextHeigth++;
                        break;
                    case 'T':
                        int[] coord = currCube.Substring(2)
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToArray();
                        nextWidth = coord[0];
                        nextDepth = coord[1];
                        break;
                    case 'S': // S + L; R; F; B; FL; FR; BL; BR
                        nextHeigth++;
                        string direction = currCube.Substring(2);
                        switch (direction)
                        {
                            case "L":
                                nextWidth--;
                                break;
                            case "R":
                                nextWidth++;
                                break;
                            case "F":
                                nextDepth--;
                                break;
                            case "B":
                                nextDepth++;
                                break;
                            case "FL":
                                nextDepth--;
                                nextWidth--;
                                break;
                            case "FR":
                                nextDepth--;
                                nextWidth++;
                                break;
                            case "BL":
                                nextDepth++;
                                nextWidth--;
                                break;
                            case "BR":
                                nextDepth++;
                                nextWidth++;
                                break;
                        }

                        
                        break;
                }

            }




            // output
            Console.WriteLine(canDrop ? "Yes" : "No");
            Console.WriteLine("{0} {1} {2}", ballWidth, ballHeigth, ballDepth);

        }
    }
}
