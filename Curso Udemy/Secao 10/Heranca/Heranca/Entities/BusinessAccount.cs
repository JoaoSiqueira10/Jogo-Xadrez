namespace Heranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        //construtor da subclasse
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) //construtor da classe Account
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
