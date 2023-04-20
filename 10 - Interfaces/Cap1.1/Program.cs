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
            WriteLine($"Enter with rental data: ");
            WriteLine($"Car model: ");
            string model = ReadLine();
            
            WriteLine($"Pick up: [dd/MM/yyyy hh:mm]");
            DateTime started = DateTime.ParseExact(ReadLine(), $"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); 
            WriteLine($"Return: [dd/MM/yyyy hh:mm]");
            DateTime finished = DateTime.ParseExact(ReadLine(), $"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Write($"Enter price per hour: $");
            double hour = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            Write($"Enter price per day: $");
            double day = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            CarRental carRental = new CarRental(started, finished, new Vehicle(model));
            RentalServices rentalServices = new RentalServices(hour, day);
            
            rentalServices.ProcessInvoice(carRental);
            WriteLine($"Invoice: ");
            WriteLine(carRental.Invoice);
        }
    }
}