using System;
using System.Globalization;


namespace cap1._4.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        
        public UsedProduct(){}

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"Procuct: {Name} (used)" +
                   $"Price: ${Price.ToString($"F2", CultureInfo.InvariantCulture)}" +
                   $"Manufactured Date: {ManufactureDate.ToString($"dd/MM/yyyy")}";
        }
    }
}