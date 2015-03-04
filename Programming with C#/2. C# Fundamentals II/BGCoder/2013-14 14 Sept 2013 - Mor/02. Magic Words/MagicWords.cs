using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Magic_Words
{
    class MagicWords
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int indexToMove = words[i].Length % (n + 1);

                string wordToMove = words[i];

                //words[i] = null;
                //words.Insert(indexToMove, wordToMove);
                //words.Remove(null);

                words.Insert(indexToMove, wordToMove);
                if (indexToMove < i)
                {
                   
                    words.RemoveAt(i + 1);
                }
                else   
                {
                   
                    words.RemoveAt(i);
                }
            }

            int maxWord = 0;

            foreach (var word in words)
            {
                if (maxWord < word.Length)
                {
                    maxWord = word.Length;
                }
            }

            var result = new StringBuilder();

            for (int i = 0; i < maxWord; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                    {
                        result.Append(word[i].ToString());
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
