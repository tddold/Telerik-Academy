namespace DocumentSystem.Models
{
    using System.Collections.Generic;
    public class MultimediaDocument : BinaryDocument, IDocument
    {
        public MultimediaDocument(string name, string content = null, int size = 0, int length = 0)
            : base(name, content, size)
        {
            this.Length = length;
        }
        public int Length { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "length")
            {
                this.Length = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.Length != 0)
            {
                output.Add(new KeyValuePair<string, object>("length", this.Length));
            }

            base.SaveAllProperties(output);
        }
    }
}
