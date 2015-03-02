using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Console_Justification
{
    class ConsoleJustification
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            List<string> words = new List<string>();
            string[] line;
            for (int i = 0; i < N; i++)
            {
                line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < line.Length; j++)
                {
                    words.Add(line[j]);

                }
            }

            StringBuilder result = new StringBuilder();
            string currLine = string.Empty;
            int currLineWordCount = 0;
            int indexToAddSpace, spaceToAdd;

            for (int i = 0; i < words.Count; i++)
            {
                if (currLine.Length + words[i].Length <= width)
                {
                    currLine += string.Format("{0} ", words[i]);
                    currLineWordCount++;
                    continue;
                }

                currLine = AddLine(width, currLine, currLineWordCount, out indexToAddSpace, out spaceToAdd);

                result.AppendLine(currLine);
                currLine = string.Format("{0} ", words[i]);
                currLineWordCount = 1;
            }

            currLine = AddLine(width, currLine, currLineWordCount, out indexToAddSpace, out spaceToAdd);

            result.Append(currLine);

            Console.WriteLine(result);
        }

        private static string AddLine(int width, string currLine, int currLineWordCount, out int indexToAddSpace, out int spaceToAdd)
        {
            currLine = currLine.Trim();
            spaceToAdd = width - currLine.Length;

            indexToAddSpace = currLine.IndexOf(" ");

            if (currLineWordCount != 1)
            {
                for (int j = 0; j < currLineWordCount && spaceToAdd > 0; j++)
                {
                    int spaces = (int)Math.Ceiling(spaceToAdd / (double) (currLineWordCount - j
- 1));
                    currLine = currLine.Insert(indexToAddSpace, new string(' ', spaces));
                    indexToAddSpace = currLine.IndexOf(" ", indexToAddSpace + spaces + 1);
                    spaceToAdd -= spaces; 

                }
            }
            return currLine;
        }

    }
}
