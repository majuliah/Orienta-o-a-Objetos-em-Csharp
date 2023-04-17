using System;
using System.IO;
using System.Net;
using static System.Console;

namespace Cap1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\majul\OneDrive\Imagens\arquivo.txt";
            //FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                //fileStream = new FileStream(path, FileMode.Open);
                //streamReader = new StreamReader(fileStream);
                
                streamReader = File.OpenText(path);

                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    WriteLine(line);                    
                }
            }
            catch (IOException exception)
            {
                WriteLine($"An error ocurred");
                WriteLine(exception.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
               // if (fileStream != null) fileStream.Close();
            }
        }
    }
}