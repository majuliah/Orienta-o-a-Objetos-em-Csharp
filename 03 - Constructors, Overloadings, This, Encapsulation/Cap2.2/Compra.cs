using System.Globalization;
namespace Cap2._2
{
    public class Compra
    {
        private string Nome;
        private double Preco;
        private int Quantidade;

        public Compra()
        {
            
        }
        public Compra(string Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return Nome
                   + ", $ "
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade
                   + " unidades, Total: $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}