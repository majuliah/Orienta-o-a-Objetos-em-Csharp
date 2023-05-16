using System;
using System.Collections.Generic;
using static System.Console;

namespace Cap1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();
            int numberOfTheStudents = 0;
            
            WriteLine($"How many students for course A?");
            int students = int.Parse(ReadLine());
            WriteLine($"Enter with the students numbers: ");
            for (int i = 0; i < students; i++)
            {
                numberOfTheStudents = int.Parse(ReadLine());
                courseA.Add(numberOfTheStudents);
            }
            
            WriteLine($"How many for course B?");
            students = int.Parse(ReadLine());
            WriteLine($"Enter with the students number: ");
            for (int i = 0; i < students; i++)
            {
                numberOfTheStudents = int.Parse(ReadLine());
                courseB.Add(numberOfTheStudents);
            }
            
            WriteLine($"Finally, enter how many students for course C: ");
            students = int.Parse(ReadLine());
            WriteLine($"Enter with students number: ");
            for (int i = 0; i < students; i++)
            {
                numberOfTheStudents = int.Parse(ReadLine());
                courseC.Add(numberOfTheStudents);
            }

            HashSet<int> unionAll = new HashSet<int>(courseA);
            unionAll.UnionWith(courseB);
            unionAll.UnionWith(courseC);
            
            WriteLine($"There is a total of {unionAll.Count} students");

        }
    }
}