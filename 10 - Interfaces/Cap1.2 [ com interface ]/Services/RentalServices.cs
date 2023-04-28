using System;
using entities;

namespace services
{
    public class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _taxService ;
        //aqui declaramos um outro serviço de imposto sem especificar qual. 

        public RentalServices(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
            //o atributo recebe o objeto que vem pelo parâmetro
            //isso se chama inversão de controle por meio de injeção de dependência 
            
            //diferente do outro código sem implementar a interface, a classe rental service não mais instancia
            // a dependência dela. Agora ela já recebe o objeto instanciado e depois atribui para o atributo.
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double taxes = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, taxes);

        }
        
        //agora temos um serviço de aluguel RentalService, que depende de um objeto ITaxService (interface)
        // o serviço (rentarService) não conhece a implementação da interface, simplesmente a recebe
        //e depois o usa, sendo assim, temos dois serviços acoplados entre si pela interface 
    }
}