using System;
using entities;

namespace services
{
    public class RentalServices
    {
        public double ValuePerHour { get; private set; }
        public double ValuePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();
        //objeto instanciado para ser utilizado mais tarde:

        public RentalServices(double valuePerHour, double valuePerDay)
        {
            ValuePerHour = valuePerHour;
            ValuePerDay = valuePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = ValuePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = ValuePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _brazilTaxService.Tax(basicPayment);
            //o _brazil tax service só foi instanciado para utilizar o seu método de cálculo de taxa aqui
            //isso significa que a classe rental service depende do _brazil tax service para realizar o cálculo 
            //da nota fiscal. isso é uma composição, acoplamento, então a classe não fica fechada para alterações.
            // se a taxa algum dia mudar, será necessário mexer em mais de uma classe para implementar as correções.
            
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}