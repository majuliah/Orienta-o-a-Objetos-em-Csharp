using System.Globalization;
using static System.Console;

namespace Cap1._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retanguloX = new Retangulo();
            string[] infos;
            double area, diagonal, perimetro;
            
            WriteLine("Entre com a Altura e a Largura do retângulo");
            infos = ReadLine().Split(' ');
            retanguloX.Altura = double.Parse(infos[0], CultureInfo.InvariantCulture);
            retanguloX.Largura = double.Parse(infos[1], CultureInfo.InvariantCulture);

            area = retanguloX.Area();
            diagonal = retanguloX.Diagonal();
            perimetro = retanguloX.Perimetro();
            
            WriteLine($"ÁREA: {area.ToString("F2", CultureInfo.InvariantCulture)}" + "\n" +
                      $"PERÍMETRO: {perimetro.ToString("F2", CultureInfo.InvariantCulture)}" + "\n" +
                      $"DIAGONAL: {diagonal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}