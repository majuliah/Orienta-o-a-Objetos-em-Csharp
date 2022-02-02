namespace Cap3._7
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeId { get; set; }
        public double EmployeeSalary { get; private set; }

        public Employee(string employeeName, string employeeId, double employeeSalary)
        {
            this.EmployeeName = employeeName;
            this.EmployeeId = employeeId;
            this.EmployeeSalary = employeeSalary;
        }

        public void AdjustingSalary(double quantity)
        {
            EmployeeSalary += EmployeeSalary * (quantity / 100.0);
        }
        
        
    }
}