using System;
using System.Collections.Generic;
using System.IO;
using Cap1._6.Entities;
using static System.Console;

namespace Cap1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\majul\Documents\ultimatePOOcSharp\exemplo.txt";

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!streamReader.EndOfStream)
                    {
                        list.Add(new Employee(streamReader.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee employee in list)
                    {
                        WriteLine(employee);
                    }
                }
            }
            catch (IOException exception)
            {
                WriteLine($"An error occurred");
                WriteLine(exception.Message);
            }
        }
    }
}