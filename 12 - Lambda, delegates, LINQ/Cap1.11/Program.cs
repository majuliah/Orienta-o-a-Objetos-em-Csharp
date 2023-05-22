using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Cap1._11.Entities;
using static System.Console;

namespace Cap1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter with the files path");
            string path = ReadLine();
            WriteLine($"Enter with the salary");
            double limit = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            List<Employees> employeesList = new List<Employees>();

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string[] fields = streamReader.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    
                    employeesList.Add(new Employees(name, email, salary));
                }

                var emailSelect = employeesList.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email)
                    .Select(obj => obj.Email);

                var resultSum = employeesList.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);
                
                WriteLine($"Email of the employees whose salary is bigger than the limit: ");
                foreach (string email in emailSelect)
                {
                    WriteLine(email);
                }
                
                WriteLine($"Sum of the salarys of the employees that the name starts with M is: ${resultSum}");
            }
            catch (IOException exception)
            {
                WriteLine(exception.Message);
            }
        }
    }
}