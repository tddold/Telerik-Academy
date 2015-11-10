namespace _03.Set_of_words.Trie
{
    using System.Collections.Generic;
    using System.Text;

    internal class Trie : ITrie
    {
        internal Trie(TrieNode rootTrieNode)
        {
            this.RootTrieNode = rootTrieNode;
        }

        private TrieNode RootTrieNode { get; set; }

        public void AddWord(string word)
        {
            this.AddWord(this.RootTrieNode, word.ToCharArray());
        }

        public ICollection<string> GetWords()
        {
            var words = new List<string>();
            var buffer = new StringBuilder();
            this.GetWords(this.RootTrieNode, words, buffer);
            return words;
        }

        public ICollection<string> GetWords(string prefix)
        {
            ICollection<string> words;
            if (string.IsNullOrEmpty(prefix))
            {
                words = this.GetWords();
            }
            else
            {
                var trieNode = this.GetTrieNode(prefix);

                // Empty list if no prefix match
                words = new List<string>();
                if (trieNode != null)
                {
                    var buffer = new StringBuilder();
                    buffer.Append(prefix);
                    this.GetWords(trieNode, words, buffer);
                }
            }

            return words;
        }

        public bool HasWOrd(string word)
        {
            var trieNode = this.GetTrieNode(word);
            return trieNode != null && trieNode.IsWord;
        }

        public int WordCount(string word)
        {
            var trieNode = this.GetTrieNode(word);

            if (trieNode == null)
            {
                return 0;
            }
            else
            {
                return trieNode.WordCount;
            }
        }

        private TrieNode GetTrieNode(string prefix)
        {
            var trieNode = this.RootTrieNode;
            foreach (var prefixChar in prefix)
            {
                trieNode.Children.TryGetValue(prefixChar, out trieNode);

                if (trieNode == null)
                {
                    break;
                }
            }

            return trieNode;
        }

        private void AddWord(TrieNode trieNode, char[] word)
        {
            if (word.Length == 0)
            {
                trieNode.IsWord = true;
                trieNode.WordCount++;
            }
            else
            {
                var ch = Utilities.FirstChar(word);
                TrieNode child;
                trieNode.Children.TryGetValue(ch, out child);

                if (child == null)
                {
                    child = TrieFactory.GetTrieNode(ch);
                    trieNode.Children[ch] = child;
                }

                var charRemoved = Utilities.FirstCharRemoved(word);
                this.AddWord(child, charRemoved);
            }
        }

        private void GetWords(TrieNode trieNode, ICollection<string> words, StringBuilder buffer)
        {
            if (trieNode.IsWord)
            {
                words.Add(buffer.ToString());
            }

            foreach (var child in trieNode.Children.Values)
            {
                buffer.Append(child.Character);
                this.GetWords(child, words, buffer);

                // Remove recent character
                buffer.Length--;
            }
        }
    }
}
