using System.Globalization;
namespace Cap2._2
{
    public class Compra
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Compra()
        {
            
        }
        public Compra(string Nome, double Preco, int Quantidade)
        {
            _nome = Nome;
            _preco = Preco;
            _quantidade = Quantidade;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }
        
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
                   + ", $ "
                   + _preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + _quantidade
                   + " unidades, Total: $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}