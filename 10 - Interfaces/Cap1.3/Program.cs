using System;
using System.Globalization;
using entities;
using static System.Console;

namespace Cap1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter rental data: ");
            WriteLine("Car model: ");
            string carModel = ReadLine();
            WriteLine($"Pick up (dd/MM/yyyy HH:mm)");
            DateTime pickup = DateTime.ParseExact(ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture );
            WriteLine($"Return (dd/MM/yyyy HH:mm)");
            DateTime returned = DateTime.ParseExact(ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture );

            CarRental rental = new CarRental(pickup, returned, new Vehicle(carModel));
        }
    }
}