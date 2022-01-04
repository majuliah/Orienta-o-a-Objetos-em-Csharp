using System.Globalization;
using static System.Console;

namespace Cap1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar calcularDolar = new Dolar();
            WriteLine("Entre com o valor em reais para converter para dólar: ");
            double valor = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            double resultado = calcularDolar.ConverterDolarEmReal(valor);
            WriteLine(resultado);

        }
    }
}