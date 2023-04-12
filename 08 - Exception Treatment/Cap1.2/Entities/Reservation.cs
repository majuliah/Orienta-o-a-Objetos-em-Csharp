using System;
using Cap1._2.Entities.Exceptions;

namespace Cap1._2.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        
        public Reservation(){}

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
                throw new DomainException($"Checkout cant be less than Check in");
            
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            
            if (checkIn < now || checkOut < now)
                throw new DomainException($"Dates must be future");
            if (checkOut <= checkIn)
                throw new DomainException($"Checkout cant be less than Check in");

            CheckIn = checkIn;
            CheckOut = checkOut;

        }

        public override string ToString()
        {
            return ($"Room number: {RoomNumber} " +
                    $"Check-In: {CheckIn.ToString($"dd/MM/yyyy")} " +
                    $"Check-Out: {CheckOut.ToString($"dd/MM/yyyy")} " +
                    $"{Duration()} nights");
        }
    }
}