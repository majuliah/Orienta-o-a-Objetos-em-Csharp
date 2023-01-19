using System;
using System.Globalization;
using EnumAndComposition.Entities;
using EnumAndComposition.Entities.Enums;
using static System.Console;

namespace EnumAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ler os dados de um funcionário com contratos e qual o salário mensal");

            WriteLine($"Here is the Departments name:");
            Department depart = new Department($"Graphics Designer");
            
            /*
            WriteLine($"Worker Level:");
            WorkerLevel level = Enum.Parse<WorkerLevel>($"senior");
            */
            
            WriteLine($"Here is workers information: ");
            Worker employee = new Worker("Maverick", WorkerLevel.junior, 3000.00, depart);

            WriteLine($"How many contracts does {employee.Name} have?");
            int contracts = 3;

            HourContract contract1 = new HourContract(DateTime.Today, 300.00, 20);
            HourContract contract2 = new HourContract(DateTime.Today, 100.00, 40);
            HourContract contract3 = new HourContract(DateTime.Today, 500.00, 10);
            
            employee.AddContract(contract1);
            employee.AddContract(contract2);
            employee.AddContract(contract3);
            
            WriteLine($"Enter the month to calculate income");
            int month = 1;
            int year = 2023;

            
            WriteLine($"Total of month 01/2023: {employee.Income(year, month).ToString($"F2", CultureInfo.InvariantCulture)}");
            
            
            WriteLine();
            
        }
    }
}