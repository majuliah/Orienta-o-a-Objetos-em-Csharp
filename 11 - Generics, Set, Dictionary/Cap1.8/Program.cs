using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace Cap1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter with the files path");
            string path = ReadLine();

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    Dictionary<string, int> votesInformation = new Dictionary<string, int>();
                    while (!streamReader.EndOfStream)
                    {
                        string[] line = streamReader.ReadLine().Split(',');
                        string candidatesName = line[0];
                        int votes = int.Parse(line[1]);

                        if (votesInformation.ContainsKey(candidatesName))
                            votesInformation[candidatesName] += votes;
                        else
                            votesInformation[candidatesName] = votes;
                    }

                    foreach (var values in votesInformation)
                    {
                        WriteLine($"{values.Key}: {values.Value}");
                    }
                }
            }
            catch (IOException exception)
            {
                WriteLine($"There is something wrong: ");
                WriteLine(exception.Message);
            }
        }
    }
}