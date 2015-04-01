namespace DocumentSystem
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Document : IDocument
    {
        public Document(string name, string content = null)
        {
            this.Name = name;
            this.Content = content;
        }

        public string Name { get; private set; }

        public string Content { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            key = key.ToLower();

            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));

            if (this.Content != null)
            {
                output.Add(new KeyValuePair<string, object>("content", this.Content));
            }
        }

        public override string ToString()
        {
            var list = new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(list);
            var props = list
                .OrderBy(KeyValuePair => KeyValuePair.Key)
                .Select(KeyValuePair => string.Format("{0}={1}", KeyValuePair.Key, KeyValuePair.Value));

            return string.Format("{0}[{1}]", this.GetType().Name, string.Join(";", props));
        }
    }
}
