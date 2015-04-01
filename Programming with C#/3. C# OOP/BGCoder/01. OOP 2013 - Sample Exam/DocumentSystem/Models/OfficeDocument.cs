namespace DocumentSystem.Models
{
    using System.Collections.Generic;
    public abstract class OfficeDocument : EncyiptableDocument, IDocument, IEncryptable
    {
        public OfficeDocument(string name, string content = null, int size = 0, string version = null)
            : base(name, content, size)
        {
            this.Version = version;
        }

        public string Version { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "version")
            {
                this.Version = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.Version != null)
            {
                output.Add(new KeyValuePair<string, object>("version", this.Version));
            }

            base.SaveAllProperties(output);
        }
    }
}
