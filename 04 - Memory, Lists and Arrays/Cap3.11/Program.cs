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
            
            //still need to calculate the readjustment
        }
    }
}