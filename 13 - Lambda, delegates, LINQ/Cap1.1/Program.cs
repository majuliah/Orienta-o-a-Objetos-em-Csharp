using System;
using System.Collections.Generic;
using Cap1._1.Entities;
using static System.Console;

namespace Cap1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Começando programação funcional");

            List<Product> lista = new List<Product>();
            lista.Add(new Product($"TV", 900.00));
            lista.Add(new Product($"Notebook", 1200.00));
            lista.Add(new Product($"Tablet", 450.00));
            
            lista.Sort(CompareProducts);
            // referência para a função, conhecida como delegate
            
            foreach (Product product in lista)
            {
                WriteLine(product);
            }
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
