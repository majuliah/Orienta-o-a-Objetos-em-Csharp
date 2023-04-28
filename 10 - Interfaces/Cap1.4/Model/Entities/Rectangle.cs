using System.Globalization;

namespace entities
{
    public class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return ($"Circle color: {Color}" +
                    $"\nWidth: {Width.ToString($"F2", CultureInfo.InvariantCulture)}" +
                    $"\nHeight: {Height.ToString($"F2", CultureInfo.InvariantCulture)}" +
                    $"\nArea: {Area().ToString($"F2", CultureInfo.InvariantCulture)}");
        }
    }
}