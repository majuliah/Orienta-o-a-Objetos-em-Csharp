using System;
using Cap01._1.Entities.Enums;
namespace Cap01._1.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime ProductOrderDay { get; set; }
        public OrderStatus StatusOrder { get; set; }


        public override string ToString()
        {
            return ($" The product {ProductName} was ordered at {ProductOrderDay} and is {StatusOrder}");
        }
    }
}