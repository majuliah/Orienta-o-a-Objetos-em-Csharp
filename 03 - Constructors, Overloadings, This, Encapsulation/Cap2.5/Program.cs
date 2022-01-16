using System.Globalization;
using static System.Console;

namespace Cap2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleBiblioteca livros;
            string[] infoLivro;
            string[] listaDeLivros = new string[5] { "O Extraordinario", "O Conto da Aia", "A Revolução dos Bichos", "Fahrenheit 451", " Admirável Mundo Novo"};
            int resposta = 9;

            while (resposta != 0)
            {
                WriteLine("Bem Vindo à Majúlia's Biblioteca :D ");
                WriteLine("Em nosso sistema, hoje em dia, podemos realizar as seguintes operações virtualmente, selecione a desejada: ");
                WriteLine("* [0] SAIR               *");
                WriteLine("* [1] COMPRAR UM LIVRO   *");
                WriteLine("* [2] VENDER UM LIVRO    *");
                WriteLine("* [3] CONSULTAR UM LIVRO *");
                resposta = int.Parse(ReadLine());

                switch (resposta)
                {
                    case 1:
                        WriteLine($"Você escolheu comprar um livro! As opções são: ");
                        for (int i = 0; i < 5; i++)
                            Write(listaDeLivros[i] + ", ");
                        WriteLine(" \n Escreva o nome do Livro que quer comprar e a quantidade");
                        infoLivro = ReadLine().Split(' ');
                        livros = new ControleBiblioteca(infoLivro[0], int.Parse(infoLivro[1]));
                        WriteLine(livros);
                        break;
                    case 2:
                        
                        WriteLine($"Você escolheu vender um livro! :) ");
                        WriteLine("Escreva o nome do Livro que quer vender e a quantidade");
                        infoLivro = ReadLine().Split(' ');
                        livros = new ControleBiblioteca(infoLivro[0], int.Parse(infoLivro[1]));
                        WriteLine(livros);
                        break;
                    
                    case 3:
                        for (int i = 0; i < 5; i++)
                            Write(listaDeLivros[i] + " ");
                        break;
                }
            }
            
            WriteLine($"Volte sempre!!!");
            
        }
    }
}