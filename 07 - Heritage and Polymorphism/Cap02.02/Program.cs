using static System.Console;
using Cap02._02.Entities;

namespace Cap02._02
{
    class Program
    {
        public static void Main(string[] args)
        {
            WriteLine(" Part two of Heritage and Polymorphism: ");
            WriteLine(" Up and Downcasting ");
            
            Account count1 = new Account(1001, "Alex", 0.0);
            BusinessAccount business1 = new BusinessAccount(2002, "Majulha", 500.00, 700.00);

            //UPCASTING:converts a subclass to a superclass
            Account account1 = business1;
            //não precisa instanciar porque ela está recebendo um obj já pronto.
            Account count2 = new BusinessAccount(3002, "Maraju", 50.00, 800.00);
            //Podemos atribuir uma subclasse pra uma variável do tipo superclasse :)
        
            Account count3 = new SavingAccounts(1008, "MariJu", 0.0, 0.01);
            //Qualquer subclasse que herda de Account :)

                    //superclass
            Account conta9 = new BusinessAccount(7006, "Maramusa", 70.00, 900.00);
                                 //subclass
            

            //DOWNCASTING
        
        
        
        }
    }
}
