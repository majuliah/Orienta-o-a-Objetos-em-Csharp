using static System.Console;
using Cap01._01.Entities;

namespace Cap01._01
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
