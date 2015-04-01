namespace DocumentSystem.Models
{
    using System.Collections.Generic;

    public class WordDocument : OfficeDocument, IDocument, IEncryptable, IEditable
    {
        public WordDocument(string name, string content = null, int size = 0, string version = null, int numberOfCharacters = 0)
            : base(name, content, size, version)
        {
            this.NumberOfCharacters = numberOfCharacters;
        }

        public int NumberOfCharacters { get; private set; }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "chars")
            {
                this.NumberOfCharacters = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (NumberOfCharacters != 0)
            {
                output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
            }

            base.SaveAllProperties(output);

        }
    }
}
