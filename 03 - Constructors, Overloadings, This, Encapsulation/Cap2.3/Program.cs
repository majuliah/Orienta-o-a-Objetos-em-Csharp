using System.Globalization;
using static System.Console;

namespace Cap2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaBanco;
        
            WriteLine("Entre com o Nome do titular: ");
            string nome = ReadLine();
            WriteLine("Entre com o número da Conta: ");
            string numeroConta = ReadLine();
            WriteLine("Você deseja fazer um depósito inicial?");
            char resposta = char.Parse(ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                WriteLine("Qual o valor do depósito?");
                double deposito = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                contaBanco = new Conta(numeroConta, nome, deposito);
            }
            else
            {
                contaBanco = new Conta(numeroConta, nome);
            }
            
            WriteLine(contaBanco);
            WriteLine($"Entre com os dados do depósito: ");
            double quantia = double.Parse(ReadLine());
            contaBanco.Deposito(quantia);
            WriteLine($"Dados da conta atualizados: ");
            WriteLine(contaBanco);
            
            WriteLine($"Entre com os dados do saque: ");
            quantia = double.Parse(ReadLine());
            contaBanco.Saque(quantia);
            WriteLine($"Dados da conta atualizados: ");
            WriteLine(contaBanco);
            
            
        }
    }
}