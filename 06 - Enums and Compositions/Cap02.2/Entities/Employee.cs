using Cap02._2.Entities.Enums;
using System.Collections.Generic;
namespace Cap02._2.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public EmployeeLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        
        public Employee(){ }

        public Employee(string name, EmployeeLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (var contracts in Contracts)
            {
                if (contracts.Date.Year == year && contracts.Date.Month == month)
                {
                    sum += contracts.TotalValue();
                }
            }

            return sum;
        }
        
        
        
        
    }
}