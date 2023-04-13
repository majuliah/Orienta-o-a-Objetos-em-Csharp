using System.Globalization;
using Cap1._3.Entities.Exceptions;

namespace Cap1._3.Entities
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double AccountBalance { get; set; }
        public double AccountWithDrawLimit { get; set; }
        
        public Account(){}

        public Account(int accountNumber, string accountHolder, double accountBalance, double accountWithDrawLimit)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            AccountBalance = accountBalance;
            AccountWithDrawLimit = accountWithDrawLimit;
        }

        public void Deposit(double amount)
        {
            AccountBalance += amount;
        }       
        public void Withdraw(double amount)
        {
            if (AccountBalance < amount)
                throw new BankException($"Balance is less than the amount you want to sack");
            if (AccountWithDrawLimit < amount)
                throw new BankException($"Withdraw limit is less than the amount you want to sack");
            
            AccountBalance -= amount;
        }

        public override string ToString()
        {
            return ($"{AccountHolder}, your new amount is ${AccountBalance.ToString($"F2", CultureInfo.InvariantCulture)}");
        }
    }
}