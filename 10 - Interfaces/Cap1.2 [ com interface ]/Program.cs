using System;
using System.Globalization;
using System.IO;
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

            try
            {
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
                //agora estamos instanciando o serviço de aluguel, passando a dependência que queremos, que é a classe concreta Brazil Tax Service
                //isso é um upcasting do construtor presente no BrazilTaxService que recebe um objeto de interface. Como o BrazilTaxService
                //tem contrato com a interface, este upcasting é perfeitamente possível
            
                rentalServices.ProcessInvoice(carRental);
                WriteLine($"Invoice: ");
                WriteLine(carRental.Invoice);
            }
            catch (IOException e)
            {
                WriteLine(e);
                throw;
            }
            
        }
    }
}