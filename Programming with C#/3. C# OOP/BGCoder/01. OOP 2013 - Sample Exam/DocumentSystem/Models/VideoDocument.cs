namespace DocumentSystem.Models
{
    using System.Collections.Generic;

    public class VideoDocument : MultimediaDocument, IDocument
    {
        public VideoDocument(string name, string content = null, int size = 0, int length = 0, int framRate = 0)
            : base(name, content, size, length)
        {
            this.FrameRate = framRate;
        }

        public int FrameRate { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "framerate")
            {
                this.FrameRate = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }


        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.FrameRate != 0)
            {
                output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
            }

            base.SaveAllProperties(output);
        }
    }
}
