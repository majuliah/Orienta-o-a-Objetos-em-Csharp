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

            //Comparison<Product> comparison = CompareProducts;
            //lista.Sort(comparison);
            //a variável comparison guarda a referência para a função
            
            //lista.Sort(CompareProducts);
            // referência para a função, conhecida como delegate

            //Comparison<Product> comparison = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //expressão lambda que ordena diretamente sem precisar de uma função que faça isso
            
            lista.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            //colocando diretamente dentro do sort para não precisar de uma variável intermediária


            foreach (Product product in lista)
            {
                WriteLine(product);
            }
        }

        //static int CompareProducts(Product p1, Product p2)
        //{
        //   return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}
