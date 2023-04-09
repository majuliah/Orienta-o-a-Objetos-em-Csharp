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

            //Downcasting -> Superclasse para subclasse:
            
            BisnessAccount conta4 = (BisnessAccount)terceiraContaComum;
            //mesmo a variável terceiraContaComum recebendo o tipo Business, o compilador só encherga o tipo da variável,
            //no caso o tipo da terceira... que é do tipo Account, então temos que fazer casting
            
            conta4.Loan(100.0); 
            //dessa forma conseguimos acessar os membros da BusinessAccount

            terceiraContaComum.Loan(); 
            //essa variável é do tipo account, e por isso não possui as propriedades da Business, mesmo
            //tendo instanciado Business Account na variável.

            if (quartaContaComum is BisnessAccount)
            {
                BisnessAccount contaCinco = (BisnessAccount)quartaContaComum;
                BisnessAccount contaSeis = quartaContaComum as BisnessAccount;
                
                //duas formas de fazer um casting
            }
        }
    }
}