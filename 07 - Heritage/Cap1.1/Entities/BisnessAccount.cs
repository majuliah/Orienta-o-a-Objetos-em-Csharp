namespace Cap1._1.Entities
{
    public class BisnessAccount : Account
    {
        public double LoanLimit { get; set; }
        
        public BisnessAccount(){}

        public BisnessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
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