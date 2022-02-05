namespace Cap3._11
{
    public class Employee : People
    {
        public int EmployeeIdNumber;
        public string EmployeeCharge;
        public double EmployeeSalary;
        
        public Employee()
        {
            
        }
        
        public Employee(string name, string middleName, int birthDate, 
            int employeeIdNumber, string employeeCharge, double employeeSalary)
        {
            this.Name = name;
            this.MiddleName = middleName;
            this.BirthDate = birthDate;   
            this.EmployeeIdNumber = employeeIdNumber;
            this.EmployeeCharge = employeeCharge;
            this.EmployeeSalary = employeeSalary;
        }

        public void RecalculateSalary(double percentage)
        {
            EmployeeSalary += EmployeeSalary * (percentage / 100.0);
        }
    }
}