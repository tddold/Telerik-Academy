namespace Bank_accounts
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Custumer custumer, decimal interestRate, decimal balance)
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

            if (this.Custumer is CompanyAccount && mounths > 12)
            {
                interest = base.CalculateInterest(mounths) / 2;
                interest += base.CalculateInterest(mounths);
                return interest;
            }
            else
            {
                interest = base.CalculateInterest(mounths) / 2;
                return interest;
            }

            if (this.Custumer is IndividualAccount)
            {
                mounths -= 6;
                interest = base.CalculateInterest(mounths);
            }

            if (mounths < 0)
            {
                return 0;
            }
           
            return interest;
        }
    }
}
