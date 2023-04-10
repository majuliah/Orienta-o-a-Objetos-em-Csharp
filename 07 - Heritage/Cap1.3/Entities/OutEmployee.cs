namespace Cap1._3.Entities
{
    public class OutEmployee : Employee
    {
        public double AdittionalCharge { get; set; }
        
        public OutEmployee(){}

        public OutEmployee(string name, int hours, double valueHour, double adittionalCharge) : 
            base(name, hours, valueHour)
        {
            AdittionalCharge = adittionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdittionalCharge;
        }
    }
}