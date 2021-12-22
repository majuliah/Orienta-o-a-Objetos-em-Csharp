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

        public void Addicionar(int quantidade)
        {
            Quantidade += quantidade;
        }
        
        public void Remover(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + "$ " + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + " em " + Quantidade + " com o valor total de R$" + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}