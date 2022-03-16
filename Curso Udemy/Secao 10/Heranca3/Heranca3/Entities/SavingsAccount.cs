namespace Heranca3.Entities
{

    //"sealed" garante segurança e performance
    //"sealed" evita que a classe seja herdada, precisa usar o "extension methods"
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //"sealed override" impede sobreposicoes multiplas
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //chama a operacao na superclasse
            Balance -= 2.0;
        }
    }
}
