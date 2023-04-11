using System;
using System.Collections.Generic;
using System.Globalization;
using Cap1._6.Entities;
using static System.Console;

namespace Cap1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Entre com o número de funcionários que deseja declarar: ");
            int anwser = int.Parse(ReadLine());
            List<PessoaBase> cadastro = new List<PessoaBase>(anwser);

            for (int i = 1; i <= anwser; i++)
            {
                Write($"Pessoa física ou Pessoa Jurídica: [ F - J ] ");
                char pessoaFouJ = char.Parse(ReadLine().ToUpper());
                Write($"Nome: ");
                string nome = ReadLine();
                Write($"Faturamento anual: ");
                double faturamento = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                if (pessoaFouJ == 'F')
                {
                    Write($"Valor com plano de saúde: ");
                    double plano = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    cadastro.Add(new PessoaFisica(nome, faturamento, plano));
                }
                else
                {
                    Write($"Quantos funcionários: ");
                    int totalColaboradores = int.Parse(ReadLine());
                    cadastro.Add(new PessoaJuridica(nome, faturamento, totalColaboradores));
                }
            }

            double soma = 0.0;
            WriteLine($"Taxas pagas: ");
            foreach (PessoaBase registros in cadastro)
            {
                WriteLine($"{registros.Nome}: R${registros.TaxasPagas().ToString("F2", CultureInfo.InvariantCulture)}");
                soma += registros.TaxasPagas();
            }
            WriteLine($"Taxas totais: {soma.ToString($"F2", CultureInfo.InvariantCulture)}");
        }
    }
}