using System;
using System.Globalization;
using entities;
using services;
using static System.Console;

namespace Cap1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter rental data: ");
            Write("Car model: ");
            string carModel = ReadLine();
            Write($"Pick up (dd/MM/yyyy HH:mm)");
            DateTime pickup = DateTime.ParseExact(ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture );
            Write($"Return (dd/MM/yyyy HH:mm)");
            DateTime returned = DateTime.ParseExact(ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture );

            Write($"Enter price per hour: ");
            double priceHour = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            Write($"Enter price per day: ");
            double priceDay = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            CarRental rental = new CarRental(pickup, returned, new Vehicle(carModel));
            RentalServices rentalServices = new RentalServices(priceHour, priceDay);
            rentalServices.ProcessInvoice(rental);
            
            WriteLine($"Invoice: ");
            WriteLine(rental.Invoice);
        }
    }
}