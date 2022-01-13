using System.Globalization;
using static System.Console;

namespace Cap2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta = 0;
            string[] criandoAconta;
            ContaBanco usuario;
            
            do
            {
                WriteLine("BEM VINDO AO BANCO MARAJUBA :D ");
                WriteLine("PARA CRIAR UMA CONTA, PRESSIONE 5: ");
                resposta = int.Parse(ReadLine());

            } while (resposta != 5);
            
            WriteLine(" ÓTIMO TER VOCÊ COM A GENTE! ");
            WriteLine(" Você agora precisa entrar com seu nome, um número de conta e se quiser fazer um saque inicial, informar o valor!");
            criandoAconta = ReadLine().Split(' ');

            
            if (criandoAconta.Length == 3)
                usuario = new ContaBanco
                    (criandoAconta[0], criandoAconta[1], 
                        double.Parse(criandoAconta[2], CultureInfo.InvariantCulture));
            else
                usuario = new ContaBanco
                    (criandoAconta[0], criandoAconta[1]);
            
            WriteLine(usuario);

            while (resposta != 0)
            {
                WriteLine($"Você deseja fazer alguma operação?");
                WriteLine($"([1] SAQUE [2] DEPOSITO [0] ENCERRA)");
                resposta = int.Parse(ReadLine());

                if (resposta == 1)
                {
                    WriteLine($"Informe qual o valor deseja sacar :)");
                    double sacar = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    usuario.Saque(sacar);
                }else if (resposta == 2)
                {
                    WriteLine($"Informe qual o valor deseja depositar :)");
                    double depositar = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    usuario.Deposito(depositar);
                }
                else
                    WriteLine($"Encerrando a operação. Foi ótimo poder atender você!");
                
                WriteLine(usuario);
            }
            
        }
    }
}