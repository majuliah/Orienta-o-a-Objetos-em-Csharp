using System.Globalization;

namespace Cap1._1.Entities
{
    public class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return ($"{Name}, {Price.ToString($"F2", CultureInfo.InvariantCulture)}");
        }
    }
}