using System;
using System.Collections.Generic;
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

            //resuming lists
            List<string> lista;
            List<string> lista2 = new List<string>();
            List<string> lista3 = new List<string>() {"Maria", "Alex", "Waldo" };
            
            //manipulando listas

            List<string> listaAdd = new List<string>();
            //add será adicionado ao fim da lista
            listaAdd.Add($"Bob");
            listaAdd.Add($"Cabeleleila"); 
            listaAdd.Add($"Leyla"); 
            listaAdd.Add($"Marleila");

            foreach (string name in listaAdd)
            {
                WriteLine(name);
            }

            List<string> listaInsert = new List<string>();
            //insert especifica qual posição adicionar item
            listaInsert.Insert(2, $"Marleilaleila");
            
            
            //matrizes: vetores bidimensionais
            //LINHA x COLUNA

            double[,] matriz1 = new double[3,3];

        }
        
    }
}