using System.Collections.Generic;
using System.Globalization;
using static System.Console;

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
                string name = ReadLine();
                string id = ReadLine();
                double salary = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                employeeRegister.Add(new Employee(name, id, salary));
                //we'll add an object at the list, and the object needs to have a name, an id and a salary :)
            }
            
            WriteLine($"Type the employee ID you want to encrease the salary: ");
            string employeeId = ReadLine();
            
            



        }
    }
}