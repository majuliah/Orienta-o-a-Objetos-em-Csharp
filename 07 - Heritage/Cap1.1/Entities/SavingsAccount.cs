namespace Cap1._1.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount(){}

        public SavingsAccount(int number, string holder, double balance, double interestRate): base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance(double balance)
        {
            Balance += Balance * InterestRate;
            //saldo é atualizado mediante a base de juros
        }
    }
}