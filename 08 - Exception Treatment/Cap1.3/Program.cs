using System;
using System.Globalization;
using Cap1._3.Entities;
using Cap1._3.Entities.Exceptions;
using static System.Console;


namespace Cap1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter account data");
            Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Write("Holder: ");
            string holder = Console.ReadLine();
            Write("Initial balance: ");
            double balance = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);
            
            WriteLine($"Enter amount for withdraw: ");
            balance = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(balance);
                WriteLine(account.ToString());
            }
            catch (BankException message)
            {
                WriteLine($"Withdraw error. {message.Message}");
                throw;
            }

            


        }
    }
}