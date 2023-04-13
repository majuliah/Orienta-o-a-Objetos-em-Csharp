using System;
using Cap1._2.Entities;
using Cap1._2.Entities.Exceptions;
using static System.Console;

namespace Cap1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Making our own exceptions");

            try
            {
                Write($"Room number: ");
                int rommnumber = int.Parse(ReadLine());
                Write($"Check in date: ");
                DateTime checkin = DateTime.Parse(ReadLine());
                Write($"Checkout date: ");
                DateTime checkout = DateTime.Parse(ReadLine());

                Reservation reservation = new Reservation(rommnumber, checkin, checkout);
                WriteLine($"Reservation: {reservation}");

                WriteLine($"Do you need to update checkin dates? [Y - N] ");
                char answer = char.Parse(ReadLine().ToUpper());
                if (answer == 'Y')
                {
                    Write($"Check in date: ");
                    checkin = DateTime.Parse(ReadLine());
                    Write($"Checkout date: ");
                    checkout = DateTime.Parse(ReadLine());

                    reservation.UpdateDates(checkin, checkout);
                    WriteLine($"Reservation: {reservation}");
                }
            }
            catch (DomainException exception)
            {
                WriteLine(exception.Message);
                throw;
            }
            catch (FormatException formatException)
            {
                WriteLine($"Format error: {formatException.Message}");
                throw;
            }
            catch (Exception e)
            {
                WriteLine($"Unexpected error.");
                throw;
            }
        }
    }
}