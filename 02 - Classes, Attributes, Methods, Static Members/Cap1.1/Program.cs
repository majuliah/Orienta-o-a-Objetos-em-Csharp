using System;
using System.Globalization;
using static System.Console;

namespace Cap1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo trianguloX, trianguloY;
            trianguloX = new Triangulo();
            trianguloY = new Triangulo();
            
            WriteLine("Entre com os três lados do triângulo X: ");
            trianguloX.ladoA = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            trianguloX.ladoB = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            trianguloX.ladoC = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            WriteLine("Agira entre com os três lados do triângulo Y: ");
            trianguloY.ladoA = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            trianguloY.ladoB = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            trianguloY.ladoC = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            double resultadoX, resutladoY, maior;

            double formulaP = (trianguloX.ladoA + trianguloX.ladoB + trianguloX.ladoC) / 2.0;
            resultadoX = Math.Sqrt(formulaP * (formulaP - trianguloX.ladoA) * (formulaP - trianguloX.ladoB) *
                                   (formulaP - trianguloX.ladoC));
            
            formulaP = (trianguloY.ladoA + trianguloY.ladoB + trianguloY.ladoC) / 2.0;
            resutladoY = Math.Sqrt(formulaP * (formulaP - trianguloY.ladoA) * (formulaP - trianguloY.ladoB) *
                                   (formulaP - trianguloY.ladoC));

            if (resultadoX > resutladoY)
                maior = resultadoX;
            else
                maior = resutladoY;
            
            WriteLine($"O triângulo X tem a área de {resultadoX.ToString("F4", CultureInfo.InvariantCulture)} e o " +
                      $"triângulo Y tem a área de {resutladoY.ToString("F4", CultureInfo.InvariantCulture)} e o maior triângulo é {maior}");


        }
    }
}