namespace Bank_accounts
{
    public abstract class Custumer
    {
        private string name;

        public Custumer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }

            private set { this.name = value; }
        }
    }
}
