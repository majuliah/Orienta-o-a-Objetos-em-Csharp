using System;
using static System.Console;
using entities;
using enums;

namespace Cap1._4
{
    class HerdarVsCumprirContrato
    {
        static void Main(string[] args)
        {
            IShape Rectangle = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black};
            IShape Circle = new Circle() { Radius = 2.0, Color = Color.White};
            WriteLine(Rectangle);
            WriteLine(Circle);
        }
    }
}