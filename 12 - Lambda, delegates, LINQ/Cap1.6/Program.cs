using System;
using System.Collections.Generic;
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
            
            list.ForEach(UpdtatePrice);
            foreach (Product p in list)
            {
                WriteLine(p);
            }

            Action<Product> action = UpdtatePrice;
            list.ForEach(action);
            //sintaxe alternativa
            
            Action<Product> action2 = p => { p.Price += p.Price * 0.10; };
            //quando uma função é void ela precisa estar entre chaves
            //sintaxe alternativa
            
            list.ForEach(p => { p.Price += p.Price * 0.10; });
            //sintaxe alternativa utilizando a expressão lambda inline
            
        }

        static void UpdtatePrice(Product p)
        {
            p.Price += p.Price * 0.10;
        }
        
        
    }
}