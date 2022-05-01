using System;
using System.Globalization;
using Cap02._2.Entities;
using Cap02._2.Entities.Enums;
using static System.Console;

namespace Cap02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] camps = new string[20];
            
            WriteLine($"Enter with the department name ");
            string departmentName = ReadLine();
            WriteLine($"Enter with the employee data: begin with the name: ");
            string employeeName = ReadLine();
            WriteLine($"Now, the level: (Junior / MidLevel / Senior )");
            EmployeeLevel level = Enum.Parse<EmployeeLevel>(ReadLine());
            WriteLine($"How much is the salary base? ");
            double baseSalary = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            Department departmentsName = new Department(departmentName);
            Employee employee = new Employee(employeeName, level, baseSalary, departmentsName);
            
            WriteLine($"How many contracts do you want to create?");
            int numbersOfContract = int.Parse(ReadLine());
            
            for (int numberContract = 0; numberContract < numbersOfContract; numberContract++)
            {
                WriteLine($"Enter with infromations with the {numberContract}º contract: ");
                Write($"Date: (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(ReadLine());
                WriteLine($"Now enter with the value per hour: ");
                double valuePerHour = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                WriteLine($"How many hours? ");
                int hours = int.Parse(ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                employee.AddContract(contract);
            }
            WriteLine($" \n Enter with month and year for calculate: MM/YYYY");
            string monthAndYear = ReadLine();
            int mont = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            
            Write($"\n Worker: {employee.Name}");
            Write($"\n Department: {employee.Department.Name}");
            Write($"\n Income for {monthAndYear}: {employee.Income(year, month)}");



        }
    }
}
