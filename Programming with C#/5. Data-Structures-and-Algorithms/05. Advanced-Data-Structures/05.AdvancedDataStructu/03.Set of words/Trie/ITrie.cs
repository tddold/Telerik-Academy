namespace _03.Set_of_words.Trie
{
    using System.Collections.Generic;

    public interface ITrie
    {
        void AddWord(string word);

        ICollection<string> GetWords();

        ICollection<string> GetWords(string prefix);

        bool HasWOrd(string word);

        int WordCount(string word);
    }
}
