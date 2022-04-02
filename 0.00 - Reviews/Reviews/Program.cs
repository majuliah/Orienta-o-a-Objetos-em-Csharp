using System.Globalization;
using static System.Console;

namespace Reviews
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bigger Salary Remembering");

            Empolyee firstEmployee = new Empolyee();
            Empolyee secondEmployee = new Empolyee();

            WriteLine($"Please, enter with the information of the first employee: 1- Name, 2- Age, 3- Salary");
            string[] informations = ReadLine().Split(' ');
            firstEmployee.Name = informations[0];
            firstEmployee.Age = int.Parse(informations[1]);
            firstEmployee.Salary = double.Parse(informations[2], CultureInfo.InvariantCulture);
            
            WriteLine($"Now, the second employee: 1- Name, 2- Age, 3- Salary");
            informations = ReadLine().Split(' ');
            secondEmployee.Name = informations[0];
            secondEmployee.Age = int.Parse(informations[1]);
            secondEmployee.Salary = double.Parse(informations[2], CultureInfo.InvariantCulture);

            if (secondEmployee.Salary > firstEmployee.Salary)
                WriteLine($"{secondEmployee.Name} is more rich!!!");
            else
                WriteLine($"{firstEmployee.Name} is more rich!!");
        }
    }
}