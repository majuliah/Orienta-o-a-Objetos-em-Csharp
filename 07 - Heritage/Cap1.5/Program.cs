using System;
using System.Collections.Generic;
using System.Globalization;
using Cap1._5.Entities;
using Cap1._5.Entities.Enums;
using static System.Console;

namespace Cap1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Write($"How many figures? ");
            int answer = int.Parse(ReadLine());
            List<Shape> figures = new List<Shape>(answer);

            for (int i = 1; i <= answer; i++)
            {
                WriteLine($"Shape data -{i}-");
                Write($"Rectangle or circle? ");
                char form = char.Parse(ReadLine().ToUpper());
                WriteLine($"Wich color? [BLACK - BLUE - RED]");
                Color color = Enum.Parse<Color>(ReadLine());

                if (form == 'R')
                {
                    Write($"Width: ");
                    double width = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    Write($"Heigh: ");
                    double heigh = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    figures.Add(new Rectangle(width, heigh, color));
                }
                else
                {
                    Write($"Radius: ");
                    double radius = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    figures.Add(new Circle(radius, color));
                }
            }
            foreach (Shape shape in figures)
            {
                WriteLine($"{shape.Area().ToString($"F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}