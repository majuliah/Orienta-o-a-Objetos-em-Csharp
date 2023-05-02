using System;
using static System.Console;

namespace Cap1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();
            WriteLine($"How many values?");
            int howMany = int.Parse(ReadLine());

            for (int i = 0; i < howMany; i++)
            {
                int number = int.Parse(ReadLine());
                printService.AddValue(number);
            }
            
            printService.Print();
            WriteLine($"Fist: {printService.First()}");
            
        }
    }
}