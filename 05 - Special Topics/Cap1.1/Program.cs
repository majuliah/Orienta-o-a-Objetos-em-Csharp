using static System.Console;

namespace Cap1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Simple if and else: Ternary");

            double salary = 20000.0;
            
            double discount = (salary < 1000.0 ) ? 0.1 : 0.5;

            double result = salary += salary * discount;
            
            Write($" Salary is: {result.ToString()}");
            
        }
    }
}