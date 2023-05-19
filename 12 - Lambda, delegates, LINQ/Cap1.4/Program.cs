using System;
using services;
using static System.Console;

namespace Cap1._4
{
    delegate void BinaryNumericOperation(double n1, double n2);
    
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation operation = CalculationService.ShowSum;
            operation += CalculationService.ShowMax;
            
            operation.Invoke(a, b);
            //sintaxe 1
            operation(a, b);
            //sintaxe 2

            WriteLine(operation);
            //resultado
        }
    }
}