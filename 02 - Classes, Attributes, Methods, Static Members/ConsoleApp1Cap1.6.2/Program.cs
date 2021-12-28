using System.Globalization;
using static System.Console;

namespace ConsoleApp1Cap1._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            string[] infos;
            double porcento;
            
            WriteLine("Entre com o Nome, Salário e o Imposto");
            infos = ReadLine().Split(' ');
            funcionario.Nome = infos[0];
            funcionario.Salario = double.Parse(infos[1], CultureInfo.InvariantCulture);
            funcionario.Imposto = double.Parse(infos[2], CultureInfo.InvariantCulture);
            
            WriteLine($"{funcionario}");
            
            
            WriteLine("Quantos porcento quer adicionar para aumento?");
            porcento = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentaSalario(porcento);
            WriteLine($"Dados atualizados do {funcionario}");
            
            
        }
    }
}