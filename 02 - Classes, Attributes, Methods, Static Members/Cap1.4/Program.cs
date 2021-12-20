using System.Globalization;
using static System.Console;

namespace Cap1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            
            Triangulo trianguloX, trianguloY;
            trianguloX = new Triangulo();
            trianguloY = new Triangulo();
            
            double areaX, areaY;
            
            WriteLine("Entre com os três valores do triângulo X");
            valores = ReadLine().Split(' ');
            trianguloX.ladoA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            trianguloX.ladoB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            trianguloX.ladoC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            areaX = trianguloX.CalculoArea();
            
                        
            WriteLine("Entre com os três valores do triângulo Y");
            valores = ReadLine().Split(' ');
            trianguloY.ladoA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            trianguloY.ladoB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            trianguloY.ladoC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            areaY = trianguloY.CalculoArea();

            if (areaX > areaY)
                WriteLine($"O maior triângulo é o X com a área de {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            else
                WriteLine($"O maior triângulo é o Y com a área de {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
            
        }
    }
}