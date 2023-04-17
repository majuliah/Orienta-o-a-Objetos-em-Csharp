using System;
using System.IO;
using static System.Console;

namespace Cap1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\majul\OneDrive\Imagens\arquivo.txt";

            try
            {
                /*
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            string line = streamReader.ReadLine();
                            WriteLine(line);
                        }
                    }
                }
                */
                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        WriteLine(line);
                    }
                }
            }
            catch (IOException exception)
            {
                WriteLine($"Something went wrong");
                WriteLine(exception.Message);
            }
        }
    }
}