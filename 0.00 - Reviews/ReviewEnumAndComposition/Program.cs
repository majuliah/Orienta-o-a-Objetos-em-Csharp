using System;
using static System.Console;
using ReviewEnumAndComposition.Entities;
using ReviewEnumAndComposition.Entities.Enums;


namespace ReviewEnumAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            Order primeiropedido = new Order {Id = 129083, Moment = DateTime.Today, Status = OrderStatus.Delivered};
            WriteLine(primeiropedido);
            string statusOrder = OrderStatus.Processing.ToString();
            WriteLine(statusOrder);

            OrderStatus pedido = Enum.Parse<OrderStatus>("Delivered");
            WriteLine(pedido);


        }
    }
}