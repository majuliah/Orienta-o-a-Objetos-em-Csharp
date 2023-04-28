using System;
using entities;

namespace services
{
    public class RentalServices
    {
        public double ValuePerHour { get; private set; }
        public double ValuePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalServices(double valuePerHour, double valuePerDay)
        {
            ValuePerHour = valuePerHour;
            ValuePerDay = valuePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = ValuePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = ValuePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _brazilTaxService.Tax(basicPayment);
            
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}