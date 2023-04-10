using System;
using static System.Console;
using System.Collections.Generic;
using System.Globalization;
using Cap1._3.Entities;

namespace Cap1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Exercício resolvido \n");

            WriteLine("************************************************************");
            WriteLine("How many employees do you want to register?");
            int register = int.Parse(ReadLine());
            List<Employee> employees = new List<Employee>();
            
            for (int listPosition = 1; listPosition <= register; listPosition++)
            {
                WriteLine($"{listPosition}º employee data");
                WriteLine($"Outsourced? [Y - N]");
                char answer = char.Parse(ReadLine().ToUpper());
                Write($"Employee name: ");
                string name = ReadLine();
                Write($"Total of hours: ");
                int totalOfHours = int.Parse(ReadLine());
                Write($"Value per hour: ");
                double valuePerHour = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

                if (answer == 'Y')
                {
                    Write($"Value of additional charge: ");
                    double additional = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutEmployee(name, totalOfHours, valuePerHour, additional));
                }
                else
                    employees.Add(new Employee(name, totalOfHours, valuePerHour));
            }
            WriteLine("************************************************************\n");
            WriteLine($"Register of employees:");
            foreach (Employee employee in employees)
            {
                WriteLine($"{employee.Name} - ${employee.Payment().ToString($"F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}