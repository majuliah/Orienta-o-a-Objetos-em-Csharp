namespace Cap1._2.Entities
{
    sealed class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        
        public SavingAccount(){}

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder,
            balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //chamamos a operação da superclasse
            Balance -= 2.0; //depois alteramos e ajustamos para o contexto
        }
    }
}