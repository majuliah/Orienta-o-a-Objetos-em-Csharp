using System;
using System.Collections.Generic;
using entities;
using static System.Console;

namespace Cap1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Predicate com RemoveAll");
            List<Product> products = new List<Product>();
            
            products.Add(new Product($"TV", 900.00));
            products.Add(new Product($"Mouse", 50.00));
            products.Add(new Product($"Tablet", 350.00));
            products.Add(new Product($"HD case", 80.90));
            products.Add(new Product($"Nintendo Switch", 2200.00));

            products.RemoveAll(p => p.Price <= 100.00);
            foreach (Product product in products)
            {
                WriteLine(product);
            }       
            
            products.RemoveAll(ProductTest);
            foreach (Product product in products)
            {
                WriteLine(product);
            }
            //sintaxe alternativa utilizando um método estático
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}