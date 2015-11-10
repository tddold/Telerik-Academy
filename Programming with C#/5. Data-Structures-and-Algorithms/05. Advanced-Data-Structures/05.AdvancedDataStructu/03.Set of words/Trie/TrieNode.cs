namespace _03.Set_of_words.Trie
{
    using System.Collections.Generic;

    internal class TrieNode
    {
        internal TrieNode(char character, IDictionary<char, TrieNode> children, bool isWord, int wordCount)
        {
            this.Character = character;
            this.Children = children;
            this.IsWord = isWord;
            this.WordCount = wordCount;
        }

        internal char Character { get; private set; }

        internal IDictionary<char, TrieNode> Children { get; private set; }

        internal bool IsWord { get; set; }

        internal int WordCount { get; set; }

        public override string ToString()
        {
            return this.Character.ToString();
        }

        public override bool Equals(object obj)
        {
            TrieNode that;

            return obj != null &&
                   (that = obj as TrieNode) != null &&
                   that.Character == this.Character;
        }

        public override int GetHashCode()
        {
            return this.Character.GetHashCode();
        }
    }
}
