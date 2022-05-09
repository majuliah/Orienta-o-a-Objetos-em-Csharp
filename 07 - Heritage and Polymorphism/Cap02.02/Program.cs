using static System.Console;
using Cap02._02.Entities;

namespace Cap02._02
{
    class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Part two of Heritage and Polymorphism: ");
            WriteLine(" Up and Downcasting ");
            
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            WriteLine(account.Balance);
            
        }
    }
}
