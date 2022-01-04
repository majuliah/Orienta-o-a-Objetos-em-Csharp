using System.Globalization;
using static System.Console;

namespace Cap1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Entre com o valor em reais para converter para dólar: ");
            double valor = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Dolar.ConverterDolarEmReal(valor);
            WriteLine(resultado);

        }
    }
}