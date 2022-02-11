using System;
using static System.Console;

namespace Cap1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("DateTime = struct -> value type");
            //O DateTime armazena Ticks. Os ticks são nanosegundos, como um hashcode
            //Que quando convertidos, geram a data atual exata. Ele começa a contar desde 01/01/01.  Exemplo: 
            
            DateTime dayOne = DateTime.Now;
            WriteLine(dayOne);
            WriteLine(dayOne.Ticks);
            
            DateTime dayTwo = DateTime.Today;
            WriteLine(dayTwo);

            DateTime dayThree = DateTime(2022, 02, 11);
            WriteLine(dayThree);
            
            DateTime dayFour = DateTime.Today;
            WriteLine(dayFour);

            DateTime dayFive = DateTime.UtcNow;
            WriteLine(dayFive);

            DateTime daySix = DateTime.Parse($"2022-02-11");
            WriteLine(daySix);

        }
    }
}
