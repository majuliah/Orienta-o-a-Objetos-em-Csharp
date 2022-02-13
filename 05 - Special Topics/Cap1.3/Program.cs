using System;
using static System.Console;

namespace Cap1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("TimeSpan \n -------- \n");
            //a struct that represents a duration
            //with ticks.

            TimeSpan timeOne = new TimeSpan(12, 35, 48 );
            WriteLine(timeOne);
            WriteLine(timeOne.Ticks);

            TimeSpan timeTwo = new TimeSpan();
            WriteLine(timeTwo);

            TimeSpan timeThree = new TimeSpan(900000000L);
            WriteLine(timeThree);

            TimeSpan timeFour = new TimeSpan(2, 14, 25, 16);
            WriteLine(timeFour);

            TimeSpan timeFive = new TimeSpan(5, 13, 14, 25, 35);
            WriteLine(timeFive);

            TimeSpan timeSix = TimeSpan.FromDays(2.5);
            WriteLine(timeSix);
            //allows conversions by days, hours, months, etc to hours

            TimeSpan timeSeven = TimeSpan.FromHours(12.7);
            WriteLine(timeSeven);

            TimeSpan timeEight = TimeSpan.FromMilliseconds(568);
            WriteLine(timeEight);
            
            




        }
    }
}