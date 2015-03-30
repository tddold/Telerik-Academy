namespace Bank_accounts
{
    public class Account : IDepositable, IDrawble
    {
        private decimal interestRate;
        private decimal balance;
        private Custumer customer;

        public Account(Custumer custumer, decimal interestRate, decimal balance)
        {
            this.Custumer = customer;
            this.InterestRate = interestRate;
            this.Balance = balance;
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }

            set { this.interestRate = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }

            set { this.balance = value; }
        }

        public Custumer Custumer
        {
            get { return this.customer; }

            set { this.customer = value; }
        }

        public virtual void Deposit(decimal money)
        {
        }

        public virtual void Withdraw(decimal money)
        {
        }

        public virtual decimal CalculateInterest(int mounths)
        {
            decimal interestForMonth = this.InterestRate * mounths;
            return interestForMonth;
        }
    }
}
