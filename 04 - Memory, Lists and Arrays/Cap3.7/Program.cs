using static System.Console;
using System.Collections.Generic;
using System.Globalization;


namespace Cap3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("First Exercice with Lists \n \n");

            WriteLine($"How many employees will be registered?");
            int quantityOfEmployees = int.Parse(ReadLine());

            List<Employee> employeeRegister = new List<Employee>();
            for (int i = 0; i < quantityOfEmployees; i++)
            {
                WriteLine($"Employee #{i + 1}");
                WriteLine($"Enter with name: ");
                string name = ReadLine();
                WriteLine($"Enter with an id: ");
                int id = int.Parse(ReadLine());
                WriteLine($"Enter with a salary: ");
                double salary = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                employeeRegister.Add(new Employee(name, id, salary));
                //we'll add an object at the list, and the object needs to have a name, an id and a salary :)
            }
            
            WriteLine($"Type the employee ID you want to encrease the salary: ");
            int idEntered = int.Parse(ReadLine());

            Employee employee = employeeRegister.Find(looking => looking.EmployeeId == idEntered);

            if (employee != null)
            {
                WriteLine($"Please, enter with the porcentage");
                double porcentage = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                employee.AdjustingSalary(porcentage);
            }
            else
            {
                WriteLine($"Employee not registered at database! ");
            }

            foreach (Employee people in employeeRegister)
            {
                WriteLine(people);
            }

        }
    }
}