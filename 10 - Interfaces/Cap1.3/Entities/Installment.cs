using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace entities
{
    public class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Date: {DueDate.ToString("dd/MM/yyyy")} \nAmount: ${Amount.ToString("F2", CultureInfo.CurrentCulture)}";
        }
    }
}