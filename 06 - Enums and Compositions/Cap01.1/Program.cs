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
            
            Order order1 = new Order
            {
                Id = 101039,
                ProductName = ($"Final Fantasy VII REMAKE"),
                ProductOrderDay = DateTime.Now,
                StatusOrder = OrderStatus.PendingPayment
            };
            
            Order newOrder = new Order
            {
                Id = 101074,
                ProductName = ($"Final Fantasy VII REMAKE"),
                ProductOrderDay = DateTime.Now,
                StatusOrder = OrderStatus.Delivered
            };
            
            WriteLine(order);
            WriteLine(order1);
            WriteLine(newOrder);
            

            string transformingToText = OrderStatus.Shipped.ToString();
            WriteLine(transformingToText);

            OrderStatus transformingToInt = Enum.Parse<OrderStatus>($"Shipped");
            WriteLine(transformingToInt);

            OrderStatus tranformingToInt2 = Enum.Parse<OrderStatus>($"PendingPayment");
            WriteLine(tranformingToInt2);
            OrderStatus transformingToInt3 = Enum.Parse<OrderStatus>($"Delivered");
            WriteLine(transformingToInt3);
            

        }
    }
}