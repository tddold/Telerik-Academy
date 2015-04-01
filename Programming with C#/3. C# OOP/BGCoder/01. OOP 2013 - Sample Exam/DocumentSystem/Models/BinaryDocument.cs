namespace DocumentSystem.Models
{
    using System.Collections.Generic;

    public class BinaryDocument : Document, IDocument
    {
        public BinaryDocument(string name, string content = null, int size = 0)
            : base(name, content)
        {
            this.Size = size;
        }

        public int Size { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "size")
            {
                this.Size = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.Size != 0)
            {
                output.Add(new KeyValuePair<string, object>("size", this.Size));                
            }

            base.SaveAllProperties(output);
        }
    }
}
