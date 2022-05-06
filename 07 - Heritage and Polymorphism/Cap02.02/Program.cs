using static System.Console;
using Cap02._02.Entities;

namespace Cap02._02
{
    class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Beginning Heritage and Polymorphism");
            WriteLine("");
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            WriteLine(account.Balance);
            
        }
    }
}
