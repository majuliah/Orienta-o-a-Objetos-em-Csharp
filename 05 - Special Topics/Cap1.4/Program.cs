using System;
using static System.Console;

namespace Cap1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Properties with DateTime:  \n");

            DateTime dateOne = new DateTime(2001, 12, 26, 08, 15, 50, 587);
            WriteLine(dateOne);
            WriteLine($"Date: " + dateOne.Date);
            WriteLine($"Day: " + dateOne.Day);
            WriteLine($"Day of Week: " + dateOne.DayOfWeek);
            WriteLine($"Day of Year: " + dateOne.DayOfYear);
            WriteLine($"Hour: " + dateOne.Hour);
            WriteLine($"Kind: " + dateOne.Kind);
            WriteLine($"Millisecond: " + dateOne.Millisecond);
            WriteLine($"Minute: " + dateOne.Minute);
            WriteLine($"Month: " + dateOne.Month);
            WriteLine($"Second: " + dateOne.Second);
            WriteLine($"Ticks: " + dateOne.Ticks);
            WriteLine($"Time Of Day: " + dateOne.TimeOfDay);
            WriteLine($"Year: " + dateOne.Year);
            
            
            WriteLine(dateOne.ToLongDateString());
            string stringStorage = dateOne.ToLongDateString();
            WriteLine(stringStorage);
            
            WriteLine(dateOne.ToLongTimeString());
            WriteLine(dateOne.ToBinary());
            WriteLine(dateOne.ToFileTime());
            WriteLine(dateOne.ToShortDateString());
            WriteLine(dateOne.ToShortTimeString());
            WriteLine(dateOne.ToString($"yyyy-MM-dd HH:mm:ss"));
            WriteLine(dateOne.ToString($"yyyy-MM-dd HH:mm:ss.fff"));


            DateTime dateTwo = dateOne.AddHours(2);
            WriteLine($"Adding 2 hours to {dateOne} = {dateTwo}");
            
            DateTime dateThree = dateOne.AddMonths(5);
            WriteLine($"Adding 5 month to {dateOne} = {dateThree}");
            
        }
    }
}