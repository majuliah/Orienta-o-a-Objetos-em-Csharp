using System;
using System.IO;
using static System.Console;

namespace Cap1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sourcePath = @"C:\Users\majul\OneDrive\Imagens\arquivo.txt";
                string targetPath = @"C:\Users\majul\OneDrive\Imagens\arquivo2.txt";

                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter streamWriter = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        streamWriter.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException exception) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(exception.Message);
            }
        }
    }
}