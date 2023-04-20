using System;
using System.Globalization;
using entities;
using services;
using static System.Console;

namespace Cap1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write($"Enter with rental data: ");
            Write($"Car model: ");
            string model = ReadLine();
            
            Write($"Pick up: [dd/MM/yyyy hh:mm] ");
            DateTime started = DateTime.ParseExact(ReadLine(), $"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); 
            Write($"Return: [dd/MM/yyyy hh:mm] ");
            DateTime finished = DateTime.ParseExact(ReadLine(), $"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Write($"Enter price per hour: $");
            double hour = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            Write($"Enter price per day: $");
            double day = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            CarRental carRental = new CarRental(started, finished, new Vehicle(model));
            RentalServices rentalServices = new RentalServices(hour, day, new BrazilTaxesService());
            
            rentalServices.ProcessInvoice(carRental);
            WriteLine($"Invoice: ");
            WriteLine(carRental.Invoice);
        }
    }
}