using System;
using System.Collections.Generic;
using System.Globalization;
using cap1._4.Entities;
using static System.Console;

namespace cap1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("How many products?");
            int total = int.Parse(ReadLine());
            List<Product> sells = new List<Product>(total);

            for (int prod = 1; prod <= total; prod++)
            {
                WriteLine($"Product {prod} data: \n");
                Write($"Common, used or imported? [C - U - I]  ");
                char answer = char.Parse(ReadLine().ToUpper());
                Write($"Product name: ");
                string prodName = ReadLine();
                Write($"Price: ");
                double price = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                if (answer == 'I')
                {
                    Write($"Customs fee: ");
                    double customFee = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    sells.Add(new ImportedProduct(prodName, price, customFee));
                }else if (answer == 'U')
                {
                    Write($"Manufacture date: ");
                    DateTime manufacturing = DateTime.Parse(ReadLine());
                    sells.Add(new UsedProduct(prodName, price, manufacturing));
                }
                else
                {
                    sells.Add(new Product(prodName, price));
                }
            }
            
            foreach (Product item in sells)
            {
                WriteLine(item.PriceTag());
            }
        }
    }
}