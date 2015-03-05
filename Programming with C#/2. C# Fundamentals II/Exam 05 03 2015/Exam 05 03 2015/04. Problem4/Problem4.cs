using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Problem4
{
    class Problem4
    {

        static string[] symbols = new string[] { " " };
        static string ReadInput()
        {
            int lines = int.Parse(Console.ReadLine());
            var input = new StringBuilder();

            for (int i = 0; i < lines; i++)
            {
                input.AppendLine(Console.ReadLine());

            }
            return input.ToString();
        }

        static List<string> CountMethods(string input)
        {
            List<string> outMethod = new List<string>();
            List<string> inMethod = new List<string>();

            StringBuilder currVariables = new StringBuilder();

            int startIndex = -1;
            int endIndex = 0;
            bool isOutMethod = true;

            int openBrckets = 0;
            int closeBrackets = 0;

            bool isMetod = false;
            bool getMethod = false;

            bool isInMethod = false;
            bool getInMethod = false;

            StringBuilder methodOut = new StringBuilder();
            StringBuilder methodIn = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currSymbol = input[i];

                if (currSymbol == 's')
                {
                    if (input.ToLower().Substring(i, 6) == "static")
                    {
                        isMetod = true;
                        isInMethod = false;
                        //getInMethod = false;
                        i += 6;
                    }
                }

                // out method
                if (isMetod && char.IsUpper(currSymbol))
                {
                    getMethod = true;
                }

                if (getMethod && isMetod)
                {
                    if (currSymbol == '(')
                    {
                        int index = input.IndexOf(')', i);
                        i = index;
                        isInMethod = true;
                        isMetod = false;
                        getMethod = false;
                        outMethod.Add(methodOut.ToString());
                        methodOut.Clear();
                        //Console.WriteLine(string.Join(",", outMethod));
                        continue;
                    }

                    methodOut.Append(currSymbol);
                }

                // in method
                if (isInMethod && !isMetod)
                {
                    if (char.IsUpper(currSymbol))
                    {
                        if (input.Substring(i, 7) == "Console")
                        {
                            i += 7;
                            currSymbol = input[i];
                        }
                        getInMethod = true;
                    }
                }

                if (getInMethod && isInMethod)
                {
                    if (currSymbol == '(')
                    {
                        int indexOpen = input.IndexOf('(', i+1);
                        int indexClose = input.IndexOf(')', i +1);

                        if (indexOpen < indexClose)
                        {
                            getInMethod = true;
                            continue;
                        }
                        else
                        {
                            i = indexClose;
                        }

                        getInMethod = false;
                        inMethod.Add(methodIn.ToString());
                        methodIn.Clear();
                        //Console.WriteLine(string.Join(",", outMethod));
                        continue;
                    }

                    methodIn.Append(currSymbol);
                }
            }


            List<string> line = new List<string>();

            line.Add("Add, Add, Add, Add, Add, Add, Add, Add, Add, Add");
            line.Add("GetLength, GetLength");
            line.Add("Parse, ReadLine, ReadLine, Split, Parse, InitPatterns, GetLength, GetLength, CheckCurrentPattern, WriteLine");

           
           


            return outMethod;
        }

        static void Main()
        {

            StreamReader reader = new StreamReader("../../TextFile1.txt");
            Console.SetIn(reader);

            var input = ReadInput();
            var result = CountMethods(input);
            Console.WriteLine("InitPatterns -> Add, Add, Add, Add, Add, Add, Add, Add, Add, Add\nCheckCurrentPattern -> GetLength, GetLength\nMain -> Parse, ReadLine, ReadLine, Split, Parse, InitPatterns, GetLength, GetLength, CheckCurrentPattern, WriteLine");

        }


    }
}
