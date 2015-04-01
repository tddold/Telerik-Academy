namespace DocumentSystem.Models
{
    using System.Collections.Generic;

    public class PDFDocument :EncyiptableDocument, IDocument, IEncryptable
    {
        public PDFDocument(string name, string content = null, int size = 0, int numberOfPages = 0)
            : base(name, content, size)
        {
            this.NumberOfPages = numberOfPages;
        }

        public int NumberOfPages { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "pages")
            {
                this.NumberOfPages = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.NumberOfPages != 0)
            {
                output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
            }

            base.SaveAllProperties(output);
        }
    }
}
