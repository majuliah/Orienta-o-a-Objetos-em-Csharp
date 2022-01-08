using static System.Console;

namespace Cap2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] infosConta;
            WriteLine("Entre com o Nome, o número da conta com 6 dígitos e o valor que quer depositar.");
            infosConta = ReadLine().Split(' ');
            Conta newConta = new Conta(infosConta[0], infosConta[1], double.Parse(infosConta[2]));

            WriteLine(" ");
            WriteLine("Você quer fazer um depósito ou uma ");
            





        }
    }
}