using System;
using Cap1._1.Entities;
using static System.Console;

namespace Cap1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Testando a visibilidade protected:");

            BisnessAccount account = new BisnessAccount(8010, $"Bob Brown", 100.0, 500.0);
            WriteLine(account.Balance);

            account.Balance = 200.00;
        }
    }
}