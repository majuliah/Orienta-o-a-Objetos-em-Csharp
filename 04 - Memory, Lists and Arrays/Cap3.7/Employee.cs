using System.Globalization;

namespace Cap3._7
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public double EmployeeSalary { get; private set; }

        public Employee(string employeeName, int employeeId, double employeeSalary)
        {
            this.EmployeeName = employeeName;
            this.EmployeeId = employeeId;
            this.EmployeeSalary = employeeSalary;
        }
        public void AdjustingSalary(double quantity)
        {
            EmployeeSalary += EmployeeSalary * (quantity / 100.0);
        }

        public override string ToString()
        {
            return ($"Name:     {EmployeeName}, \n" +
                    $"Id:       {EmployeeId}, \n" +
                    $"Salary: R${EmployeeSalary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}