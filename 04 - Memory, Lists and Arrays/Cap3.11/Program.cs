using System.Collections.Generic;
using System.Globalization;
using static System.Console;

namespace Cap3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the HR Department. How many employees do you want to register today? ");
            int employeeQuantity = int.Parse(ReadLine());

            List<Employee> newEmployees = new List<Employee>();
            for (int i = 0; i < employeeQuantity; i++)
            {
                WriteLine($"Please, enter withe the Name, " +
                          $"Middle Name, Birth Year, an Id number, a charge and the salary!");
                
                string[] employeeRegister = ReadLine().Split(' ');
                newEmployees.Add(new Employee(employeeRegister[0],employeeRegister[1], 
                    int.Parse(employeeRegister[2]), int.Parse(employeeRegister[3]), 
                    employeeRegister[4], double.Parse(employeeRegister[5], CultureInfo.InvariantCulture)));
            }
            
            WriteLine($"Do you want to increase any employee salary?");
            char answer = char.Parse(ReadLine());

            switch (answer)
            {
                case 'y':
                    WriteLine($"Enter with the employee id: ");
                    int idPassed = int.Parse(ReadLine());
                    Employee employeeSelected = newEmployees.Find(id => id.EmployeeIdNumber == idPassed);
                    if (employeeSelected != null)
                    {
                        WriteLine($"Enter with the percentage: ");
                        double percentage = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                        employeeSelected.RecalculateSalary(percentage);
                    }
                    else
                    {
                        WriteLine($"Employee not found! Try again");
                    }
                    break;
                case 'n':
                    WriteLine($"Ending execution.");
                    break;
            }

            foreach (Employee registered in newEmployees)
            {
                WriteLine(registered);
            }
            
        }
    }
}