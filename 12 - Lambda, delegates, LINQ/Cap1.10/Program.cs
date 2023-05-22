using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using entities;
using static System.Console;

namespace Cap1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter with the files path: ");
            string path = ReadLine();

            List<Product> products = new List<Product>();

            using (StreamReader streamReader = File.OpenText(path))
            {
                while (!streamReader.EndOfStream)
                {
                    string[] fields = streamReader.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
            }

            var average = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            WriteLine($"Average price: {average.ToString($"F2", CultureInfo.InvariantCulture)}");
            var names = products.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                WriteLine(name);                
            }
        }
    }
}