using System;

namespace EnumAndComposition.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValueHour { get; set; }
        public int Hours { get; set; }
        
        public HourContract(){}

        public HourContract(DateTime date, double valueHour, int hours)
        {
            Date = date;
            ValueHour = valueHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValueHour;
        }
    }
}