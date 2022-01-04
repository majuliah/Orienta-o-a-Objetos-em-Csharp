namespace Cap1._8
{
    public class Dolar
    {

        public double ConverterDolarEmReal(double valorEmReais)
        {
            double valorDolar = valorEmReais * 5.45;
            double valorTotal = valorDolar + (valorDolar * 0.6);
            return valorTotal;
        }
    }
}