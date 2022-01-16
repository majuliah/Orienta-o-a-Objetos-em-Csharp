using System.Globalization;

namespace Cap2._5
{
    public class ControleBiblioteca
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; private set; }

        public ControleBiblioteca(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
            Valor = 10.20;
        }
        public double ValorCompraOuVenda()
        {
            return Valor * Quantidade;
        }

        public override string ToString()
        {
            return ($"Você adquiriu o livro {Nome}, em {Quantidade} e deu o total de R${ValorCompraOuVenda().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}