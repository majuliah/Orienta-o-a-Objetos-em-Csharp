using System;
using static System.Console;

namespace Cap1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numberOne = int.Parse(ReadLine());
                int numberTwo = int.Parse(ReadLine());

                int division = numberOne / numberTwo;
                WriteLine(division);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Division by 0 is not allowed!");
            }
            catch(FormatException e)
            {
                WriteLine($"Is not possible divide letters " + e.Message);
            }
        }
    }
}