using System;
using System.IO;
using static System.Console;

namespace Cap1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoOrigem = @"C:\Users\majul\OneDrive\Imagens\arquivo.txt";
            string caminhoOrigem2 = "C:\\Users\\majul\\OneDrive\\Imagens\\arquivo2.txt";

            try
            {
                FileInfo infoFile = new FileInfo(caminhoOrigem);
                infoFile.CopyTo(caminhoOrigem2);

                string[] lines = File.ReadAllLines(caminhoOrigem);
                foreach (string line in lines)
                    WriteLine(line);
            }
            catch (IOException exception)
            {
                WriteLine($"An error ocurred");
                WriteLine(exception.Message);
            }
        }
    }
}