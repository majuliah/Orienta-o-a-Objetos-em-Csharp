using System;
using System.Globalization;
using static System.Console;

namespace AlongTimeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello Bitches");

            Product[] arrayOfExample = new Product[3];

            for (int i = 0; i < 3; i++)
            {
                WriteLine($"Enter with a name: ");
                string name = ReadLine();
                WriteLine($"Enter with a price");
                double price = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                arrayOfExample[i] = new Product(name, price);
            }

            double sum = 0.0;
            for (int i = 0; i < 3; i++)
            {
                sum += arrayOfExample[i].Price;
            }

            double average = sum / 3;
            
            WriteLine(@$"The average of the products is {average.ToString("F2", CultureInfo.InvariantCulture)}");
            
            WriteLine($"-----------------------------");

            double summing = Calculator.Calculinator(2, 3, 4, 5, 6, 7);
            
            WriteLine($"The result: {summing}");

            //object triple = 78.3;
        }
        
    }
}