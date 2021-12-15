using System;
//referência ao namespace padrão do .net que manipula funções básicas, como console.writeLine


namespace Cap1._1
//boas práticas: sempre colocar as classes dentro de um namespace
{
    class Program
    //declaração de classe. O nome da classe é sempre o mesmo nome do arquivo por questões de organização.
    {
        static void Main(string[] args)
        //membro da classe. é uma declaração padrão do c# para indicar o entry point do programa, ou seja, vai executar este pedaço de código 
        //no entry point do programa
        {
            Console.WriteLine("Hello World!");
        }
    }
}