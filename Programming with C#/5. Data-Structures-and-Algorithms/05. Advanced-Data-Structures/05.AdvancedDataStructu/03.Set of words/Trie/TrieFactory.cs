namespace _03.Set_of_words.Trie
{
    using System.Collections.Generic;

    public class TrieFactory
    {
        public static ITrie GetTrie()
        {
            return new Trie(GetTrieNode(' '));
        }

        internal static TrieNode GetTrieNode(char character)
        {
            return new TrieNode(character, new Dictionary<char, TrieNode>(), false, 0);
        }
    }
}
