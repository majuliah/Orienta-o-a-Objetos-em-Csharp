using System.Globalization;
using static System.Console;

namespace Cap1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario1, funcionario2;
            funcionario1 = new Funcionarios();
            funcionario2 = new Funcionarios();
            
            WriteLine("Entre com o nome e o salário do primeiro funcionario");
            funcionario1.nome = ReadLine();
            funcionario1.salario = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            WriteLine("Entre com o nome e o salário do segundo funcionario");
            funcionario2.nome = ReadLine();
            funcionario2.salario = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.salario + funcionario2.salario) / 2;
            
            WriteLine($"A média dos salários de {funcionario1.nome} e {funcionario2.nome} é R${media.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}