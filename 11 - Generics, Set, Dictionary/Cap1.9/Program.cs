using System;
using static System.Console;

namespace Cap1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Extension Methods!");
            DateTime dateTime = new DateTime(2018, 11, 16, 8, 10, 45);
            WriteLine(dateTime.ElapsedTime());

            string morning = $"Good morning bitch";
            WriteLine(morning.Cut(5));
        }
    }
}