using System;
using System.IO;
using static System.Console;

namespace Cap1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Message();
            
            WriteLine($"Enter file full path: ");
            string path = ReadLine();

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        WriteLine(line);
                    }
                }
            }
            catch(IOException exception)
            {
                WriteLine(exception.Message);
            }

















        }
        
        static void Message()
        { 
            WriteLine("Um site registra um log de acessos dos usuários. Um registro" +
                    "\nde log consiste no nome do usuário e o instante em que ele" +
                    "\nacessou o site no padrão ISO8601, separados por espaço, con-" +
                    "\nforme exemplo. Fazer um programa que leia o log de acessos a" +
                    "\npartir de um arquivo, e informe quantos usuários distintos" +
                    "\nacessaram o site.\n");
        }
    }
}