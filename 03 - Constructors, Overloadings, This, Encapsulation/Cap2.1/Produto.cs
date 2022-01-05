using System.Globalization;
namespace Cap2._1
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            
        }
        
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 10;
            //a quantidade igual a 0 é dispensável, isso só mostra
            //que podemos colocar qualquer valor para iniciar a quantidade
            
        }
        
        
        
        public double ValorTotalEmEstoque() 
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) 
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) 
        {
            Quantidade -= quantidade;
        }
        public override string ToString() 
        {
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