using entities;

namespace services
{
    public class RentalServices
    {
        public double ValuePerHour { get; private set; }
        public double ValuePerDay { get; private set; }

        public RentalServices(double valuePerHour, double valuePerDay)
        {
            ValuePerHour = valuePerHour;
            ValuePerDay = valuePerDay;
        }
        
        public void ProcessInvoice(CarRental carRental)
        {}
    }
}