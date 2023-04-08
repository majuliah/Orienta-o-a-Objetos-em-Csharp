namespace Cap1._1.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        //protected quer dizer que somente subclasses podem alterar os valores.
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        
        public Account(){}

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        
        
    }
}