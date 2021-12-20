using static System.Console;

namespace Cap1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();
            
            WriteLine("Entre com o nome e idade para a primeira pessoa: ");
            pessoa1.nome = ReadLine();
            pessoa1.idade = int.Parse(ReadLine());
            
            WriteLine("Agora entre com o nome e idade da segunda pessoa: ");
            pessoa2.nome = ReadLine();
            pessoa2.idade = int.Parse(ReadLine());
            

            if (pessoa1.idade > pessoa2.idade)
                WriteLine($"{pessoa1.nome} é mais velha(o) com {pessoa1.idade}");
            else
                WriteLine($"{pessoa2.nome} é mais velha(o) com {pessoa2.idade}");
        }
    }
}