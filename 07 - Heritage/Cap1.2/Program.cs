using System;
using Cap1._2.Entities;
using static System.Console;

namespace Cap1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Sobreposição, virtual, override e base");
            Account clienteUm = new Account(1001, $"Magda", 500.0);
            Account clienteDois = new SavingAccount(10002, $"Martha", 500.0, 0.01);
            
            clienteUm.Withdraw(10.0);
            clienteDois.Withdraw(10.0);
            
            WriteLine(clienteUm.Balance + $"\n" + clienteDois.Balance);
        }
    }
}