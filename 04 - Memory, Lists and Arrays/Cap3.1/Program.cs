using static System.Console;

namespace Cap3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1, p2, p3;
            p1 = new Product("TV", 900, 10);
            
            p2 = p1;
            p3 = null;
            
            
            WriteLine("");
        }
    }
}