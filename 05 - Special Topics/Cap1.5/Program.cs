using System;
using static System.Console;

namespace Cap1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Properties and operations with TimeSPan");
            
            TimeSpan timeOne = TimeSpan.MaxValue;
            WriteLine(timeOne);
            
            TimeSpan timeTwo = TimeSpan.MinValue;
            WriteLine(timeTwo);
            
            TimeSpan timeThree = TimeSpan.Zero;
            WriteLine(timeThree);

            TimeSpan timeFour = new TimeSpan(2, 3, 4, 5, 6);
            WriteLine(timeFour.Days);
            WriteLine(timeFour.Hours);
            WriteLine(timeFour.Minutes);
            WriteLine(timeFour.Milliseconds);
            WriteLine(timeFour.Seconds);
            WriteLine(timeFour.Ticks);
            
            WriteLine(timeFour.TotalDays);
            WriteLine(timeFour.TotalHours);
            WriteLine(timeFour.TotalMilliseconds);
            WriteLine(timeFour.TotalMinutes);
            WriteLine(timeFour.TotalSeconds);


            TimeSpan timeFive = new TimeSpan(1, 30, 10);
            TimeSpan timeSix = new TimeSpan(0, 10, 5);

            TimeSpan sum = timeFive.Add(timeSix);
            WriteLine(sum);

            TimeSpan sub = timeFive.Subtract(timeSix);
            WriteLine(sub);

            TimeSpan mult = timeFive.Multiply(2.0);
            WriteLine(mult);

            TimeSpan div = timeFive.Divide(1.5);
            WriteLine(div);
            

        }
    }
}