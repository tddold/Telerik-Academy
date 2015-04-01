namespace DocumentSystem.Models
{
    using System.Collections.Generic;
    public class ExcelDocument :OfficeDocument, IDocument, IEncryptable
    {
        public ExcelDocument(string name, string content = null, int size = 0, string version = null, int numberOfRows = 0, int numberOfColmns = 0)
            : base(name, content, size, version)
        {
            this.NumberOfRows = numberOfRows;
            this.NumberOfColmns = numberOfColmns;
        }

        public int NumberOfRows { get; private set; }

        public int NumberOfColmns { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            key = key.ToLower();

            if (key == "rows")
            {
                this.NumberOfRows = int.Parse(value);
            }
            else if (key == "cols")
            {
                this.NumberOfColmns = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.NumberOfRows != 0)
            {
                output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
            }

            if (this.NumberOfColmns != 0)
            {
                output.Add(new KeyValuePair<string, object>("cols", this.NumberOfColmns));
            }

            base.SaveAllProperties(output);
        }
    }
}
