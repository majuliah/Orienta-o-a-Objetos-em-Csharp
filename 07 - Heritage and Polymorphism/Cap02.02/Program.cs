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
                                     //var count2 é uma variável do tipo do businessccount MAS está armazenada em uma var do tipo Account.
            BusinessAccount count4 = count2;
                //vai dar erro porque estamos tentando atribuir uma superclasse pra uma subclasse, e isso não pode ser feito implícitamente.

            //para converter o count 2 para o tipo Business, é preciso fazer a conversão explícita

            BusinessAccount count5 = (BusinessAccount) count2;
            //Agora a var count5 tem os atributos do businessaccount
            count5.Loan(100.00);
                  //see?

            count2.Loan();
                  //erro porque: Mesmo sendo instanciada como businessAccount, a variavel count2 é do tipo Account, e o Loan é propriedade do businessAccount
                    //Mesmo instanciado como BusinessAccount, o compilador não sabe que ele é desse tipo por ter sido atribuído a um tipo Account.
                    //Só funcionaria se fizéssemos o downcasting

            //Part of tests:

            //Downcasting é uma operação não segura porque 
            //as vezes pode ser executada de forma errada e o compilador só percebe em tempo de compilação.
            //Exemplo:
             BusinessAccount account6 = (BusinessAccount) conta9;
             //Na hora de compilar vai dar erro, porque a variável 9 é do tipo SavingAccount. E não podemos 
             //converter uma subclasse para outra

            //PARA TESTAR SE UM OBJ É DE UM TIPO OU DE OUTRO

                if(conta9 is BusinessAccount)
                {
                    BusinessAccount conta6 = (BusinessAccount)conta9;
                    conta6.Loan(100.00);
                    WriteLine("Loan executed!!");
                }

                if(conta9 is SavingAccounts)
                {
                    SavingAccounts conta6 = (SavingAccounts)conta9;
                    // a palavra as substitui este casting:
                    SavingAccounts conta7 = conta9 as SavingAccounts;
                    conta6.UpdateBalance();
                    WriteLine("Updated:) ");
                }









































        
        
        
        }
    }
}
