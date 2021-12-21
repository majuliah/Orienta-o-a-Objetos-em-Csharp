using System.Globalization;
using static System.Console;

namespace Cap1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produto = new Produtos();
            
            WriteLine("Entre com o nome, quantidade e valor do produto: ");
            produto.Nome = ReadLine();
            produto.Quantidade = int.Parse(ReadLine());
            produto.Valor = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            WriteLine("Dados do produto: " + produto);
            
        }
    }
}