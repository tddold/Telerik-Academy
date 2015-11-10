namespace _03.Set_of_words
{
    using _03.Set_of_words.Trie;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class SetOfWords
    {
        private static readonly Stopwatch Sw = new Stopwatch();
        private static readonly Random Rnd = new Random();

        public static void Main()
        {
            var trie = TrieFactory.GetTrie();

            var words = GenerateRandomWords(1000000);
            var uniqueWords = new HashSet<string>(words);

            AddWordsToTrie(words, trie);
            GetCountOfAllUniqueWords(uniqueWords, trie);
        }
        private static ICollection<string> GenerateRandomWords(int count)
        {
            Console.Write("Generation random words... ");
            Sw.Start();

            var words = new List<string>(count);

            for (int i = 0; i < count; i++)
            {
                words.Add(GetRandomWord());
            }

            Sw.Stop();
            Console.WriteLine("\rGeneration random words -> Total words: {0} | Elapsed time: {1}\n", words.Count, Sw.Elapsed);
            Sw.Reset();

            return words;
        }

        private static string GetRandomWord()
        {
            var newWord = new char[Rnd.Next(3, 7)];

            for (int i = 0; i < newWord.Length; i++)
            {
                newWord[i] = ((char)Rnd.Next(97, 122));
            }

            return new string(newWord);
        }

        private static void AddWordsToTrie(ICollection<string> words, ITrie trie)
        {
            Console.Write("Adding words to trie... ");
            Sw.Start();

            foreach (var word in words)
            {
                trie.AddWord(word);
            }

            Sw.Stop();
            Console.WriteLine("\rAdding words to trie -> Elapsed time: {1}\n", words.Count, Sw.Elapsed);
            Sw.Reset();
        }

        private static void GetCountOfAllUniqueWords(ICollection<string> wordsForSearcing, ITrie trie)
        {
            Console.Write("Searching words... ");
            Sw.Start();

            foreach (var word in wordsForSearcing)
            {
                trie.WordCount(word); // return the number of words    
            }

            Sw.Stop();
            Console.WriteLine("\rSearching words -> Unique words: {0} | Elapsed time: {1}\n", wordsForSearcing.Count, Sw.Elapsed);
            Sw.Reset();
        }
    }
}
