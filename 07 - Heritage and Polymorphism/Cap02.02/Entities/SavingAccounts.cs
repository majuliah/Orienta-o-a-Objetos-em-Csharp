namespace Cap02._02.Entities
{
    class SavingAccounts : Account
    {
        public double InterestRate { get; set; }

        public SavingAccounts(){}

        public SavingAccounts(int number, string holder, double balance, double interestRate): base (number, holder, balance){
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }




    }
}