using System.Globalization;

namespace Cap1._5._1
{
    public class Produto
    {
        public string Nome;
        public int Quantidade;
        public double Valor;

        public double valorTotal()
        {
            return Quantidade * Valor;
        }

        public void Adicionar(int qtde)
        {
            Quantidade += qtde;
        }

        public void Remover(int qtde)
        {
            Quantidade -= qtde;
        }

        public override string ToString()
        {
            return (Nome + ", R$" + Valor.ToString("F2", CultureInfo.InvariantCulture) + " em " + Quantidade +
                    " no estoque, tem o total de R$" + valorTotal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}