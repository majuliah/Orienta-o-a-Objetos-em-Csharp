using System;
using System.Collections.Generic;
using System.Linq;
using Cap1._6.Entities;
using static System.Console;

namespace Cap1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Fazer um programa que aumente o valor dos produtos em 10%");

            List<Product> list = new List<Product>();
            
            list.Add(new Product($"TV", 900.00));
            list.Add(new Product($"Mouse", 50.00));
            list.Add(new Product($"Tablet", 350.50));
            list.Add(new Product($"HD case", 80.90));

            List<string> result = list.Select(NameUpper).ToList();

            foreach (string item in result)
            {
                WriteLine(item);
            }

            Func<Product, string> func = NameUpper;
            List<string> result2 = list.Select(func).ToList();
            //sintaxe alternativa utilizando um delegate para armazenar a referência da função
            
            Func<Product, string> func2 = p => p.Name.ToUpper();
            //sintaxe alternativa utilizando expressão lambda
            
            List<string> result3 = list.Select(p => p.Name.ToUpper()).ToList();
            //sintaxe alternativa utilizando expressão lamda inline
            
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}