using System;
using System.Globalization;
using System.Numerics;

namespace entities
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }

        public override string ToString()
        {
            return ($"Circle color: {Color}" +
                    $"\nRadius: {Radius.ToString($"F2", CultureInfo.InvariantCulture)}" +
                    $"\nArea: {Area().ToString($"F2", CultureInfo.InvariantCulture)}");
        }
    }
}