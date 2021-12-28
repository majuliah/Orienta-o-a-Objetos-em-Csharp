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
            double media, quantoFalta;
            
            WriteLine("Entre com o nome e as três notas de um aluno:");
            notas = ReadLine().Split(' ');
            aluno.Nome = notas[0];
            aluno.Nota1 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(notas[3], CultureInfo.InvariantCulture);

            media = aluno.CalculaMedia();

            if (media >= 60.0)
                WriteLine($"{aluno.Nome} foi APROVADO COM MEDIA {media.ToString("F2", CultureInfo.InvariantCulture)}");
            else
            {
                quantoFalta = (60.0 - media);
                WriteLine($"{aluno.Nome} REPROVADO. Faltavam {quantoFalta.ToString("F2", CultureInfo.InvariantCulture)} para passar.");
            }

        }
    }
}