using static System.Console;
using System.Globalization;

namespace Cap2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("E.N.C.A.P.S.U.L.A.M.E.N.T.O");
            
            Compra p = new Compra();
            WriteLine("Entre os dados do produto:");
            Write("Nome: ");
            p.Nome = ReadLine();
            Write("Preço: ");
            p.Preco = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(ReadLine());
            WriteLine();
            WriteLine("Dados do produto: " + p);
            WriteLine();
            Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(ReadLine());
            p.AdicionarProdutos(qte);
            WriteLine();
            WriteLine("Dados atualizados: " + p);
            WriteLine();
            Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(ReadLine());
            p.RemoverProdutos(qte);
            WriteLine();
            WriteLine("Dados atualizados: " + p);
        }
    }
}