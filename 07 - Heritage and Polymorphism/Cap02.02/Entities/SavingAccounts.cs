namespace Cap02._02.Entities
{
    class SavingAccounts : Account
    {
        public double InterestRate { get; set; }

        public SavingAccounts(){}

        public SavingAccounts(int number, string holder, double balance): base (number, holder, balance){
            
        }




    }
}