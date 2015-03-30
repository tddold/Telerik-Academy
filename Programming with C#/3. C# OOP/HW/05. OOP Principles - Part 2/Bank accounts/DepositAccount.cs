namespace Bank_accounts
{
    public class DepositAccount : Account, IDepositable, IDrawble
    {
        public DepositAccount(Custumer custumer, decimal interestRate, decimal balance)
            : base(custumer, interestRate, balance)
        {
        }

        public override void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public override void Withdraw(decimal money)
        {
            this.Balance -= money;
        }

        public override decimal CalculateInterest(int mounths)
        {
            decimal interest;

            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
               interest = base.CalculateInterest(mounths);
            }

            return interest;
        }
    }
}
