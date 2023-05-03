using System;
using System.Collections.Generic;
using System.Globalization;
using entities;
using services;
using static System.Console;

namespace Cap1._2
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<Product> list = new List<Product>();
            WriteLine($"Enter with the size of the list: ");
            int size = int.Parse(ReadLine());

            for (int i = 0; i < size; i++)
            {
                string[] vet = ReadLine().Split(',');
                string name = vet[0];
                double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(list);
            
            WriteLine($"Max: {max}");
            
        }
    }
}