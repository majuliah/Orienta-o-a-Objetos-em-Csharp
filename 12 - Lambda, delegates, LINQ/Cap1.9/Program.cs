using System;
using System.Collections.Generic;
using System.Linq;
using entities;
using static System.Console;

namespace Cap1._9
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            WriteLine(message);
            foreach (T obj in collection)
            {
                WriteLine(obj);
            }
            WriteLine();
        }
        
        static void Main(string[] args)
        {
            WriteLine("LINQ com LAMBDA");
            Category c1 = new Category() { Id = 1, Name = $"Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = $"Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = $"Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){Id = 1, Name = $"Computer", Price = 1100.00, Category = c2},
                new Product(){Id = 1, Name = $"Hammer", Price = 90.00, Category = c1},
                new Product(){Id = 1, Name = $"TV", Price = 1700.00, Category = c3},
                new Product(){Id = 1, Name = $"Notebook", Price = 1300.00, Category = c2},
                new Product(){Id = 1, Name = $"Saw", Price = 80.00, Category = c1},
                new Product(){Id = 1, Name = $"Tablet", Price = 700.00, Category = c2},
                new Product(){Id = 1, Name = $"Camera", Price = 700.00, Category = c3},
                new Product(){Id = 1, Name = $"Printer", Price = 350.00, Category = c3},
                new Product(){Id = 1, Name = $"MacBook", Price = 1800.00, Category = c2},
                new Product(){Id = 1, Name = $"Sound Bar", Price = 700.00, Category = c3},
                new Product(){Id = 1, Name = $"Level", Price = 70.00, Category = c1}
            };
            
            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            var r1 = from p in products where p.Category.Tier == 1 && p.Price < 900 select p;
            Print($"TIER 1 AND PRICE < 900.00", r1);

            //var r2 = products.Where(p => p.Category.Name == $"Tools").Select(p => p.Name);
            var r2 = from p in products where p.Category.Name == "Tools" select p.Name;
            Print($"NAMES OF PRODUCTS FROM TOOLS", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
            var r3 = from p in products where p.Name[0] == 'C' select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print($"NAMES STARTED WITH C AND ANONYMOUS OBJECT", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 = from p in products where p.Category.Tier == 1 orderby p.Name orderby p.Price select p;
            Print($"TIER 1 ORDER BY PRICE THENBY NAME", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4 select p).Skip(2).Take(4);
            Print($"TIER 1 ORDER BY PRICE THENBY NAME SKIPPING 2 AND TAKING 4", r5);

            //var r6 = products.First();
            var r6 = (from p in products select p).FirstOrDefault();
            WriteLine($"First test1: {r6}");           
            
            //var r7 = products.FirstOrDefault();
            var r7 = (from p in products where p.Price > 3000.00 select p).FirstOrDefault();
            WriteLine($"First test1: {r6}");
            

            //var r18 = products.GroupBy(p => p.Category);
            var r18 = from p in products group p by p.Category;

            foreach (IGrouping<Category, Product> group in r18)
            {
                WriteLine($"Category {group.Key.Name}: ");
                foreach (Product p in group)
                {
                    WriteLine(p);
                }
                WriteLine();
            }
        }
    }
}