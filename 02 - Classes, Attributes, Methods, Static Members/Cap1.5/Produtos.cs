using System.Globalization;

namespace Cap1._5
{
    public class Produtos
    {
        public string Nome;
        public int Quantidade;
        public double Valor;

        public double ValorTotalEstoque()
        {
            return Valor * Quantidade;
        }

        public override string ToString()
        {
            return Nome + "$ " + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + " em " + Quantidade + " com o valor total de R$" + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}