namespace DocumentSystem.Models
{
    public abstract class EncyiptableDocument : BinaryDocument, IDocument, IEncryptable
    {
        public EncyiptableDocument(string name, string content = null, int size = 0, string version = null)
            : base(name, content, size)
        {
            this.IsEncrypted = false;
        }

        public bool IsEncrypted { get; private set; }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override string ToString()
        {
            if (this.IsEncrypted)
            {
                return string.Format("{0}[encrypted]", this.GetType().Name);
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
