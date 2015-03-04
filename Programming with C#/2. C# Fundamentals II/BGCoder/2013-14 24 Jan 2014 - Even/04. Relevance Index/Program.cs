using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Relevance_Index
{
    class Program
    {
        static string[] symbols = new string[] { " ", ",", ".", "(", ")", ";", "-", "!", "?" };

        static void Main()
        {
            string searchWord = Console.ReadLine();

            int numberOfParagraph = int.Parse(Console.ReadLine());

            List<string> paragraphs = new List<string>();
            List<int> index = new List<int>();

            for (int i = 0; i < numberOfParagraph; i++)
            {
                int relevantIndex = 0;

                var currLineWords = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < currLineWords.Length; j++)
                {
                    string word = currLineWords[j];

                    if (searchWord.ToLower() == word.ToLower())
                    {
                        relevantIndex++;
                        currLineWords[j] = word.ToUpper();
                    }
                }

                paragraphs.Add(string.Join(" ", currLineWords));
                index.Add(relevantIndex);
            }

            List<string> sortedParagraph = new List<string>();


            while (sortedParagraph.Count < paragraphs.Count)
            {
                int maxIndex = 0;
                int maxParagraphIndex = 0;

                for (int i = 0; i < index.Count; i++)
                {
                    if (maxIndex < index[i])
                    {
                        maxIndex = index[i];
                        maxParagraphIndex = i;
                    }
                }

                sortedParagraph.Add(paragraphs[maxParagraphIndex]);
                index[maxParagraphIndex] = -1;
            }

            Console.WriteLine(string.Join(Environment.NewLine, sortedParagraph));
        }
    }
}
