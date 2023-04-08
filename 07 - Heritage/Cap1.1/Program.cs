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

            //account.Balance = 200.00;
            
            WriteLine("Testando Upcast e Downcast:");
            Account contaComum = new Account(1001, "Alex", 0.0);
            BisnessAccount contaBusiness = new BisnessAccount(10002, $"Marvin", 0.0, 500.0);
            
            //Upcasting -> Subclasse para superclasse:
            Account novaContaComum = contaBusiness; // variável criada para receber um objeto já pronto do tipo businessAccount
            Account terceiraContaComum = new BisnessAccount(10078, $"Jenna", 0.02, 1000.0);
            //instanciando diretamente um objeto do tipo business em uma conta comum
            Account quartaContaComum = new SavingsAccount(10098, $"Lenna", 0.05, 0.01);



        }
    }
}