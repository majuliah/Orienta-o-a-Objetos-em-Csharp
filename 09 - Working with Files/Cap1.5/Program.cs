using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;

namespace Cap1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\majul\Documents\Exemplos";

                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                WriteLine($"FOLDERS: ");
                foreach (string folder in folders)
                {
                    WriteLine(folder);
                }                
                
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                WriteLine($"FILES: ");
                foreach (string file in files)
                {
                    WriteLine(file);
                }

                Directory.CreateDirectory(path + "\\NewFolder");
                Directory.CreateDirectory(@"C:\Users\majul\Documents\Exemplos\NovaFolder");
            }
            catch (IOException exception)
            {
                WriteLine($"An error occurred.");
                WriteLine(exception.Message);
            }
        }
    }
}