using static System.Console;
using System.Globalization;

namespace Cap1._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            string[] dadosProduto;
            
            WriteLine("Entre com o Nome, Quantidade e Valor do produto: ");
            dadosProduto = ReadLine().Split(' ');
            produto.Nome = dadosProduto[0];
            produto.Quantidade = int.Parse(dadosProduto[1]);
            produto.Valor = double.Parse(dadosProduto[2], CultureInfo.InvariantCulture);
            WriteLine($"Dados do produto: {produto.ToString()}");
            
            WriteLine($"Você quer ADICIONAR(1) ou REMOVER(2) o produto {produto.Nome} do estoque?");
            int decisao = int.Parse(ReadLine());

            if (decisao == 1)
                WriteLine($"Quantas unidades quer adicionar?");
            else
                WriteLine($"Quantas unidades quer remover?");
            
            int quantidade = int.Parse(ReadLine());
            
            switch (decisao)
            {
                case 1:
                    produto.Adicionar(quantidade);
                    WriteLine($"Dados do produto após adição: {produto.ToString()}");
                    break;
                case 2:
                    produto.Remover(quantidade);
                    WriteLine($"Dados do produto após remoção: {produto.ToString()}");
                    break;
                default:
                    WriteLine($"Opção inválida. Encerrando o programa");
                    break;
            }
        }
    }
}