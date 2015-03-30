namespace Bank_accounts
{
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Custumer custumer, decimal interestRate, decimal balance)
            : base(custumer, interestRate, balance)
        {
        }

        public override void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public override decimal CalculateInterest(int mounths)
        {
            decimal interest;

            if (this.Custumer is IndividualAccount)
            {
                mounths -= 3;
            }
            else if (this.Custumer is CompanyAccount)
            {
                mounths -= 2;
            }
            else if (mounths < 0)
            {
                return 0;
            }

            interest = base.CalculateInterest(mounths);
            return interest;
        }
    }
}
