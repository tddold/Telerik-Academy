using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.The_Horror
{
    class TheHorror
    {
        static void Main()
        {
            //int bufSize = 1024;
            //Stream inStream = Console.OpenStandardInput(bufSize);
            //Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));

            //// input
            //StringBuilder input = new StringBuilder(Console.ReadLine());

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if ((int)input[i] < 48 || (int)input[i] > 57)
            //    {
            //        input.Remove(i,1);
            //    }
            //}

            //Console.WriteLine(input);

            string input = Console.ReadLine();

            int result = 0;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {

                    switch (input[i])
                    {
                        case '0':
                            count++;
                            result += 0;
                            break;
                        case '1':
                            count++;
                            result += 1;
                            break;
                        case '2':
                            count++;
                            result += 2;
                            break;
                        case '3':
                            count++;
                            result += 3;
                            break;
                        case '4':
                            count++;
                            result += 4;
                            break;
                        case '5':
                            count++;
                            result += 5;
                            break;
                        case '6':
                            count++;
                            result += 6;
                            break;
                        case '7':
                            count++;
                            result += 7;
                            break;
                        case '8':
                            count++;
                            result += 8;
                            break;
                        case '9':
                            count++;
                            result += 9;
                            break;
                        default:
                            throw new ArgumentException();
                            break;
                    }
                }
            }

            // print
            Console.WriteLine("{0} {1}", count, result);
        }
    }
}
