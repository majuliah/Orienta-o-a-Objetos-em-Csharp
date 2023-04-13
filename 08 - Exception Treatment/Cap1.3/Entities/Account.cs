namespace Cap1._3.Entities
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double AccountBalance { get; set; }
        public double AccountWithDraw { get; set; }
        
        public Account(){}

        public Account(int accountNumber, string accountHolder, double accountBalance, double accountWithDraw)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            AccountBalance = accountBalance;
            AccountWithDraw = accountWithDraw;
        }

        public void Deposit(double amount)
        {
            
        }
        
        
    }
}