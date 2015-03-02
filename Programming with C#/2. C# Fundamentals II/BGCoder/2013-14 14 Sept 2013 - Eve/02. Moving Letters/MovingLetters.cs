using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moving_Letters
{
    class MovingLetters
    {
        static StringBuilder ExtractingTheLetters(string[] words)
        {
            StringBuilder result = new StringBuilder();

            int maxWord = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];
                if (maxWord < currWord.Length)
                {
                    maxWord = currWord.Length;
                }
            }

            for (int i = 0; i < maxWord; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string currWord = words[j];

                    if (i < currWord.Length)
                    {
                        int indexRemoveLetter = currWord.Length - 1 - i;
                        result.Append(currWord[indexRemoveLetter]);
                    }
                }
            }

            return result;
        }

        static string MovingTheLetters(StringBuilder text)
        {
            int numberToMove = 0;
            int nextPosition = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currSymbol = text[i];
                numberToMove = Char.ToLower(currSymbol) - 'a' + 1;
                nextPosition = (i + numberToMove) % text.Length;

                text.Remove(i, 1);
                text.Insert(nextPosition, currSymbol);
            }

            return text.ToString();
        }

        static void Main()
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string result = MovingTheLetters(ExtractingTheLetters(words));

            Console.WriteLine(result);

        }
    }
}
