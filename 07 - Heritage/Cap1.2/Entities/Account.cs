namespace Cap1._2.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        
        public Account(){}

        public Account(int number, string name, double balance)
        {
            Number = number;
            Name = name;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        
    }
}