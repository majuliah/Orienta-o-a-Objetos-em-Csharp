using System;
using Cap01._1.Entities;
using Cap01._1.Entities.Enums;
using static System.Console;

namespace Cap01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            Order order = new Order
            {
                Id = 101000,
                ProductName = ($"Final Fantasy VII REMAKE"),
                ProductOrderDay = DateTime.Now,
                StatusOrder = OrderStatus.Processing
            };
            WriteLine(order);

            string transformingToText = OrderStatus.Shipped.ToString();
            WriteLine(transformingToText);

            OrderStatus transformingToInt = Enum.Parse<OrderStatus>($"Shipped");
            WriteLine(transformingToInt);
            


        }
    }
}