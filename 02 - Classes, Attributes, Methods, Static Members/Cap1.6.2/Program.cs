using System.Diagnostics.Contracts;
using System.Globalization;
using static System.Console;

namespace Cap1._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ALuno aluno = new ALuno();
            string[] notas;

            WriteLine("Entre com o nome e as três notas de um aluno:");
            notas = ReadLine().Split(' ');
            aluno.Nome = notas[0];
            aluno.Nota1 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(notas[3], CultureInfo.InvariantCulture);
            
            WriteLine($"{aluno.Nome} tem a nota {aluno.CalculaNota().ToString("F2", CultureInfo.InvariantCulture)}");

            if(aluno.Aprovado())
                WriteLine($"APROVADO!");
            else
                WriteLine($"REPROVADO! Falta {aluno.Reprovado().ToString($"F2",CultureInfo.InvariantCulture)} pontos para a aprovação");
        }
    }
}