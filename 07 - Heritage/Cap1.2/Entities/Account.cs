namespace Cap1._2.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Name { get; protected set; }
        public double Balance { get; protected set; }
        
        public Account(){}

        public Account(int number, string name, double balance)
        {
            Number = number;
            Name = name;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        
    }
}