using System;
using System.IO;
using static System.Console;

namespace Cap1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\majul\Documents\Exemplos\file1.txt";
            
            WriteLine($"Getting directory Separator Char: {Path.DirectorySeparatorChar}");
            WriteLine($"Getting path separator: {Path.PathSeparator}");
            WriteLine($"Getting file name: {Path.GetFileName(path)}");
            WriteLine($"Getting directory name: {Path.GetDirectoryName(path)}");
            WriteLine($"Getting file name without extension: {Path.GetFileNameWithoutExtension(path)}");
            WriteLine($"Getting file extension: {Path.GetExtension(path)}");
            WriteLine($"Getting full path: {Path.GetFullPath(path)}");
            WriteLine($"Getting systems temp path: {Path.GetTempPath()}");
        }
    }
}